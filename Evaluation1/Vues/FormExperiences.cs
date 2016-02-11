using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChasseurDeTetes.Vues
{
    /// <summary>
    /// Feuille de gestion des expériences,elle charge les expériences d'un candidat puis permet de les voir,les créer,modifier et supprimer.
    /// </summary>
    public partial class FormExperiences : Form
    {
        //variables
        #region
        /// <summary>
        /// Candidat récupérer depuis la feuille d'initialisation
        /// </summary>
        private Metier.Candidat LeCandidat;
        /// <summary>
        /// Expérience utilisé pour manipuler le Datagriview.
        /// </summary>
        private Metier.Experience exp = new Metier.Experience();
        /// <summary>
        /// Booléen vérifiant si la modification à été utilisée.
        /// </summary>
        private bool isModifier;
        /// <summary>
        /// Booléen vérifiant si la création à été utilisée.
        /// </summary>
        private bool isCreer;
        /// <summary>
        /// Booléen Confirmant si l'expérience est valide.
        /// </summary>
        private bool isValid = true;
        /// <summary>
        /// Erreur utilisée lorsqu'un champ n'est pas valide. 
        /// </summary>
        ErrorProvider error = new ErrorProvider();
        #endregion

        //Démarrage
        #region
        /// <summary>
        /// Initialisation de la feuille d'expériences.
        /// </summary>
        /// <param name="Cand">Candidat Selectionné dans la feuille d'initialisation</param>
        public FormExperiences(Metier.Candidat Cand)
        {
            LeCandidat = Cand;
            InitializeComponent();

        }
        /// <summary>
        /// Evenement du chargement de la feuille, toutes les donnée nécessaire à la feuille sont récupérés depuis la base de données.
        /// </summary>
        /// <param name="sender"> Contrôle de l'évenement.</param>
        /// <param name="e">Arguments.</param>
        private void FormExperiences_Load(object sender, EventArgs e)
        {
            exp.IdCandidat = LeCandidat.IdCandidat;
            Affichage("AV");
            try
            {
                // Cette liste sert au tris du DataGridView ainsi qu'à l'affectation du bindingsource
                LeCandidat.Experiences = Dao.DaoExperiences.GetAllExperiences(LeCandidat);
                //empêche Le Datagrid view d'afficher une expérience vide.
                if (LeCandidat.Experiences.Count > 0)
                {
                    Trier(LeCandidat.Experiences);
                }
                qualificationBindingSource.DataSource = Dao.DaoQualifications.GetAllQualifications();
                entrepriseBindingSource.DataSource = Dao.DaoEntreprise.GetAllEntreprises();
            }
            catch (Exceptions.DaoException.DAOExceptionFinApplication fin)
            {
                MessageBox.Show(fin.Message);
                Application.Exit();
            }
        }
        #endregion

        //Bouttons et DataGridView
        #region
        /// <summary>
        /// Gestion du click dans le Datagridview.
        /// 3 possibilités: Détails,Modifier et supprimer.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void dataGridViewExperiences_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // empêche le click en dehors des cellules
            if (e.ColumnIndex > 1 && e.RowIndex != -1)
            {
                // récupération de la cellule
                DataGridViewCell cell = dataGridViewExperiences.Rows[e.RowIndex].Cells[e.ColumnIndex];
                exp = (Metier.Experience)dataGridViewExperiences.CurrentRow.DataBoundItem;
                if (cell.Value.ToString() == "Modifier")
                {
                    isModifier = true;
                    exp.IdExperience = ((Metier.Experience)dataGridViewExperiences.CurrentRow.DataBoundItem).IdExperience;
                    Affichage("MA");
                }
                if (cell.Value.ToString() == "Détails")
                {
                    Affichage("D");
                }
                if (cell.Value.ToString() == "Supprimer")
                {
                    DialogResult dr = MessageBox.Show("Etes vous sûr de vouloir supprimer cette expérience?", "Suppression expérience", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Delexp(exp);
                        experienceBindingSource.ResetBindings(false);
                    }
                }
            }
        }
        /// <summary>
        /// Evénement lorsqu'on appuit sur "Quitter", la feuille ce ferme.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
        /// <summary>
        /// Evénement du bouton "Ajouter", permet ce créer une expérience.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            isCreer = true;
            exp = new Metier.Experience(LeCandidat.IdCandidat);
            Affichage("MA");
        }
        /// <summary>
        /// Evénement du bouton Valider.Lance la validation des champs puis l'ajout ou la modification de l'expérience.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            error.SetError(maskedTextBoxDateD, "");
            if (isModifier || isCreer)
            {
                GetBoxes();
                switch (Validation(exp))
                {
                    case 1:
                        error.SetError(maskedTextBoxDateD, "Veuillez entrer une date");
                        maskedTextBoxDateD.Focus();
                        isValid = false;
                        break;
                    case 2:
                        error.SetError(maskedTextBoxDateD, "Veuillez entrer une date correcte");
                        maskedTextBoxDateD.Focus();
                        isValid = false;
                        break;
                    case 3:
                        MessageBox.Show("Veuillez entrer une entreprise ou écrire un commentaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValid = false;
                        break;
                    case 0:
                        if (isModifier)
                        {
                            Updexp(exp);
                            isModifier = false;
                        }
                        else
                        {
                            Addexp(exp);
                            isCreer = false;
                        }
                        experienceBindingSource.Clear();
                        Trier(LeCandidat.Experiences);
                        experienceBindingSource.ResetBindings(true);
                        Affichage("AV");
                        break;
                }

            }
            isValid = true;
        }
        /// <summary>
        /// Evénement du bouton Annuler. Annule toute modification ou ajout d'expérience.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Affichage("AV");
        }
        #endregion

        //Controles
        #region
        /// <summary>
        /// Evénement lorsque le champ de Date de Début est validé ou non.
        /// S'il n'est pas valide une erreur ce lance et le focus est remis sur le champ.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void maskedTextBoxDateD_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                error.SetError(maskedTextBoxDateD, "Veuillez entrer une date correcte");
                maskedTextBoxDateD.Focus();
                buttonValider.Enabled = false;
            }
            else
            {
                error.SetError(maskedTextBoxDateD, "");
                buttonValider.Enabled = true;
            }
        }
        /// <summary>
        /// Evénement lorsque le champ de Date de Fin est validé ou non.
        /// S'il n'est pas valide une erreur ce lance et le focus est remis sur le champ.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void maskedTextBoxDateF_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            //"  /  /" représente la maskedTextbox vide
            if (e.IsValidInput || maskedTextBoxDateF.Text == "  /  /")
            {
                error.SetError(maskedTextBoxDateF, "");
                buttonValider.Enabled = true;
            }
            else
            {
                error.SetError(maskedTextBoxDateF, "Veuillez entrer une date correcte");
                maskedTextBoxDateF.Focus();
                buttonValider.Enabled = false;

            }
        }
        /// <summary>
        /// Evénement lorsque la feuille ce ferme. Une boîte de dialogue apparaît.
        /// Si la réponse est oui, la feuille ce ferme et la feuille d'initialisation revient.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void FormExperiences_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Fin de la gestion?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Program.Init.Show();
            }
            else { e.Cancel = true; }
        }
        #endregion

        //Méthodes
        #region
        /// <summary>
        /// Méthode gérant les différant Affichages de la feuille.
        /// </summary>
        /// <param name="aff">Paramètre d'affichage. 3 possibilités: "MA", "D" et "AV" </param>
        private void Affichage(string aff)
        {
            switch (aff)
            {
                //Gestion affichage modification et ajout
                case ("MA"): groupBoxDetail.Visible = true; dataGridViewExperiences.Enabled = false; Vues.Affichage.EtablirChamp(true, panelChamps); ButtonEnable(true); CLearErrors(); FillBoxes(); break;
                //Gestion affichage détail
                case ("D"): groupBoxDetail.Visible = true; Vues.Affichage.EtablirChamp(false, panelChamps); labelCommentaire.Enabled = true; ButtonEnable(true); FillBoxes(); buttonValider.Hide(); dataGridViewExperiences.Enabled = false; CLearErrors(); break;
                //Gestion affiachage annuler et valider
                case ("AV"): groupBoxDetail.Visible = false; ButtonEnable(false); dataGridViewExperiences.Enabled = true; break;
            }
        }
        /// <summary>
        /// Méthode permettant d'afficher ou non les boutons Valider,Anuuler et Ajouter
        /// </summary>
        /// <param name="bl">Booléen. Si vrai, les boutons Valider et Annuler sont visible alors que Ajouter ne l'est pas.
        /// Si Faux, c'est l'inverse.</param>
        private void ButtonEnable(bool bl)
        {
            buttonValider.Visible = bl;
            buttonAnnuler.Visible = bl;
            buttonAjouter.Visible = !bl;
        }
        /// <summary>
        /// Méthode de remplissage des champs.
        /// </summary>
        private void FillBoxes()
        {
            maskedTextBoxDateD.Text = exp.DateDebut.ToString();
            maskedTextBoxDateF.Text = exp.DateFin.ToString();
            comboBoxQualif.SelectedItem = exp.LaQualif;
            if (exp.Lentreprise == null) { comboBoxEntreprise.SelectedValue = 0; }
            else { comboBoxEntreprise.SelectedItem = exp.Lentreprise; }
            textBoxCommentaire.Text = exp.Commentaire;
        }
        /// <summary>
        /// Méthode de récupération du contenu des champs.
        /// </summary>
        private void GetBoxes()
        {
            exp.DateDebut = Convert.ToDateTime(maskedTextBoxDateD.Text);
            if (maskedTextBoxDateF.Text == "  /  /") { exp.DateFin = null; }
            else { exp.DateFin = Convert.ToDateTime(maskedTextBoxDateF.Text); }
            exp.LaQualif = (Metier.Qualification)comboBoxQualif.SelectedItem;
            if (comboBoxEntreprise.SelectedText == "Aucune") { exp.Lentreprise = null; }
            else { exp.Lentreprise = (Metier.Entreprise)comboBoxEntreprise.SelectedItem; }
            if (textBoxCommentaire.Text == "") { exp.Commentaire = null; }
            else { exp.Commentaire = textBoxCommentaire.Text; }
        }
        /// <summary>
        /// Méthode de suppression des erreurs.
        /// </summary>
        private void CLearErrors()
        {
            error.SetError(maskedTextBoxDateF, "");
            error.SetError(maskedTextBoxDateD, "");
            buttonValider.Enabled = true;
        }
        /// <summary>
        /// Méthode de Validation des Dates.
        /// </summary>
        /// <param name="DD">Date de Début.</param>
        /// <param name="DF">Date de Fin (Peux être nulle).</param>
        /// <returns></returns>
        public static bool ValidationDate(DateTime DD, DateTime? DF)
        {
            if (DF == null) { return true; }
            if (DateTime.Compare(DD, (DateTime)DF) < 0) { return true; }
            return false;
        }
        /// <summary>
        /// Méthode de Validation de l'expérience (modifiée ou ajoutée).
        /// </summary>
        /// <param name="expe">Expérience Testée.</param>
        /// <returns></returns>
        public static int Validation(Metier.Experience expe)
        {
            // La date de début de peux être valide que si elle a moins de 60ans
            if (expe.DateDebut < DateTime.Today.AddYears(-60)) { return 1; }
            if (!ValidationDate(expe.DateDebut, expe.DateFin)) { return 2; }
            if (expe.Lentreprise.IdEntreprise == 0 && expe.Commentaire == null) { return 3; }
            return 0;
        }
        /// <summary>
        /// Méthode de Tris du DataGridView.
        /// </summary>
        /// <param name="le">liste des expériences.</param>
        private void Trier(List<Metier.Experience> le)
        {
            //tris par Date de début en ordre croissant 
            var expes = le.OrderBy(x => x.DateDebut);
            experienceBindingSource.DataSource = expes;
        }
        /// <summary>
        /// Méthode d'ajout d'une expérience.
        /// </summary>
        /// <param name="xp">Expérience ajoutée.</param>
        private void Addexp(Metier.Experience xp)
        {
            Dao.DaoExperiences.AddExperience(exp);
            experienceBindingSource.Add(exp);
            LeCandidat.Experiences.Add(exp);
        }
        /// <summary>
        /// Méthode de suppression d'une expérience.
        /// </summary>
        /// <param name="xp">Expérience supprimée.</param>
        private void Delexp(Metier.Experience xp)
        {
            Dao.DaoExperiences.DelExperience(xp);
            experienceBindingSource.Remove(xp);
            LeCandidat.Experiences.Remove(xp);
        }
        /// <summary>
        /// Méthode de modification d'une expérience.
        /// </summary>
        /// <param name="xp">Expérience modifiée.</param>
        private void Updexp(Metier.Experience xp)
        {
            Delexp(xp);
            Dao.DaoExperiences.UpdExperience(xp);
            Addexp(xp);
        }
        #endregion
    }
}