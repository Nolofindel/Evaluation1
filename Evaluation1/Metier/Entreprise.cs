using System;
using System.Collections.Generic;

namespace ChasseurDeTetes.Metier
{
    /// <summary>
    /// Classe de l'entreprise.
    /// </summary>
    public class Entreprise
    {
        public Entreprise(int idEntreprise)
        {
            IdEntreprise = idEntreprise;
        }

        public Entreprise()
        {
        }
        /// <summary>
        /// Id de l'entreprise.
        /// </summary>
        public int? IdEntreprise { get; set; }
        /// <summary>
        /// Nom de l'entreprise.
        /// </summary>
        public string RaisonSociale { get; set; }
        /// <summary>
        /// Addresse principal de l'entreprise.
        /// </summary>
        public string Adresse1Ent { get; set; }
        /// <summary>
        /// Addresse secondaire de l'entreprise.
        /// </summary>
        public string Adresse2Ent { get; set; }
        /// <summary>
        /// Code Postal de l'entreprise.
        /// </summary>
        public string CpEnt { get; set; }
        /// <summary>
        /// Ville de l'entreprise.
        /// </summary>
        public string VilleEnt { get; set; }
        /// <summary>
        /// Indique si l'entreprise est cliente
        /// </summary>
        public bool Cliente { get; set; }
        /// <summary>
        /// Contact de l'entreprise
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// Numéro de téléphone du contact de l'entreprisse.
        /// </summary>
        public string TelContact { get; set; }
        /// <summary>
        /// Addresse mail du cantact de l'entreprise.
        /// </summary>
        public string MailContact { get; set; }
        /// <summary>
        /// Date de création de l'entreprise.
        /// </summary>
        public DateTime DateCreation { get; set; }
        /// <summary>
        /// Secteur d'activité de l'entreprise
        /// </summary>
        public Activite SecteurActivite { get; set; }
        /// <summary>
        /// Pôle d'embauche de l'entreprise.
        /// </summary>
        public PoleEmbauche PoleRattachement { get; set; }
        /// <summary>
        /// Liste des Missions liées à l'entreprise.
        /// </summary>
        public List<Mission> Missions { get; set; }
        /// <summary>
        /// Test d'égalité de l'entreprise avec une autre.
        /// </summary>
        /// <param name="obj">Entreprise.</param>
        /// <returns>Si vrai, les entreprises sont les mêmes.Sinon elles sont différentes.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Entreprise && ((Entreprise)obj).IdEntreprise == IdEntreprise) { return true; }
            else { return false; }
        }
    }
}