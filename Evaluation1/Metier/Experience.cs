using System;

namespace ChasseurDeTetes.Metier
{
    /// <summary>
    /// Classe de l'expérience.
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
        /// Id de l'expérience.
        /// </summary>
        public int IdExperience { get; set; }
        /// <summary>
        /// Id du candidat à qui appartient l'expérience.
        /// </summary>
        public int IdCandidat { get; set; }
        /// <summary>
        /// Date de début de l'expérience.
        /// </summary>
        public DateTime DateDebut { get; set; }
        /// <summary>
        /// Date de fin de l'expérience.
        /// </summary>
        public DateTime? DateFin { get; set; }
        /// <summary>
        /// Commentaire sur l'expérience.
        /// </summary>
        public string Commentaire { get; set; }
        /// <summary>
        /// Qualification de l'expérience.
        /// </summary>
        public Qualification LaQualif { get; set; }
        /// <summary>
        /// Entreprise de l'expérience.
        /// </summary>
        public Entreprise Lentreprise { get; set; }
        /// <summary>
        /// Test d'égalité de l'expérience avec une autre.
        /// </summary>
        /// <param name="obj">Expérience.</param>
        /// <returns>Si vrai, les expériences sont les mêmes.Sinon elles sont différentes.</returns>
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