using System;

namespace ChasseurDeTetes.Metier
{
    /// <summary>
    /// Classe de l'exp�rience.
    /// </summary>
    public class Experience
    {
        public Experience(int idExperience, int idCandidat, DateTime dateDebut, DateTime dateFin, string commentaire, Qualification laQualif, Entreprise lentreprise)
        {
            IdExperience = idExperience;
            IdCandidat = idCandidat;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Commentaire = commentaire;
            LaQualif = laQualif;
            Lentreprise = lentreprise;
        }

        public Experience()
        {
        }

        public Experience(int idCandidat)
        {
            IdCandidat = idCandidat;
            IdExperience = 0;
            DateDebut = DateTime.Today;
            DateFin = null;
            Commentaire = null;
            LaQualif = new Qualification(1);
            Lentreprise = null;
        }
        /// <summary>
        /// Id de l'exp�rience.
        /// </summary>
        public int IdExperience { get; set; }
        /// <summary>
        /// Id du candidat � qui appartient l'exp�rience.
        /// </summary>
        public int IdCandidat { get; set; }
        /// <summary>
        /// Date de d�but de l'exp�rience.
        /// </summary>
        public DateTime DateDebut { get; set; }
        /// <summary>
        /// Date de fin de l'exp�rience.
        /// </summary>
        public DateTime? DateFin { get; set; }
        /// <summary>
        /// Commentaire sur l'exp�rience.
        /// </summary>
        public string Commentaire { get; set; }
        /// <summary>
        /// Qualification de l'exp�rience.
        /// </summary>
        public Qualification LaQualif { get; set; }
        /// <summary>
        /// Entreprise de l'exp�rience.
        /// </summary>
        public Entreprise Lentreprise { get; set; }
        /// <summary>
        /// Test d'�galit� de l'exp�rience avec une autre.
        /// </summary>
        /// <param name="obj">Exp�rience.</param>
        /// <returns>Si vrai, les exp�riences sont les m�mes.Sinon elles sont diff�rentes.</returns>
        public override bool Equals(object obj)
        {
            return obj is Experience && ((Experience)obj).IdExperience == IdExperience;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}