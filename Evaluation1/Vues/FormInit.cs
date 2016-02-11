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
    /// Première feuille chargée, elle sert à sélectionner un candidat et à quitter l'application.
    /// </summary>
    public partial class FormInit : Form
    {
        //Démarrage
        #region
        /// <summary>
        /// Initialisation de la feuille.
        /// </summary>
        public FormInit()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Chargement de la feuille, les candidat sont récupéré depuis la base de donnée à ce moment là.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void FormInit_Load(object sender, EventArgs e)
        {
            try
            {
                candidatBindingSource.DataSource = Dao.DaoCandidat.GetAllCandidats();
            }
            catch (Exceptions.DaoException.DAOExceptionFinApplication fin)
            {
                MessageBox.Show(fin.Message);
                Application.Exit();
            }
        }
        #endregion

        //Bouttons
        #region
        /// <summary>
        /// Evénement lorsqu'on clique sur "Quitter", fait quitter l'application.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void buttonQuitter_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
        /// <summary>
        /// Evenement lorsqu'on clique sur "Valider",Lance une feuille de gestion d'expériences du candidat sélectionné.
        /// </summary>
        /// <param name="sender"> Contrôle de l'évenement.</param>
        /// <param name="e">Arguments.</param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (comboBoxCandidat.SelectedIndex != -1)
            {
                Vues.FormExperiences FormCandidat = new FormExperiences((Metier.Candidat)comboBoxCandidat.SelectedItem);
                FormCandidat.Show();
                Program.Init.Hide();
            }
        }
        #endregion

        //Evenements
        #region
        /// <summary>
        /// Evénement lorsqu'on ferme l'application, une boîte de dialogue s'ouvre et demande confirmation de la fermeture.
        /// Si non est choisit, la fin de l'application est annulée.Sinon elle continue.
        /// </summary>
        /// <param name="sender"> Contrôle de l'événement.</param>
        /// <param name="e">Arguments.</param>
        private void FormInit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Fin de l'application?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }

            #endregion

        }
    }
}