using System;
using System.Collections.Generic;

namespace ChasseurDeTetes.Metier
{
    /// <summary>
    /// Classe du Candidat
    /// </summary>
    public class Candidat
    {

        public Candidat(int idCandidat, string nom, string prenom, DateTime dateNaissance, string telephone, string adresseMail, bool situationProfess, bool mobilite, SituationFamiliale situationF, PoleEmbauche poleRattachement)
        {
            IdCandidat = idCandidat;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Telephone = telephone;
            AdresseMail = adresseMail;
            SituationProfess = situationProfess;
            Mobilite = mobilite;
            SituationF = situationF;
            PoleRattachement = poleRattachement;
        }

        public Candidat()
        {
        }

        /// <summary>
        /// Id du candidat.
        /// </summary>
        public int IdCandidat { get; set; }
        /// <summary>
        /// Nom du candidat.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Pr�nom du candidat.
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Date de naissance du candidat.
        /// </summary>
        public DateTime DateNaissance { get; set; }
        /// <summary>
        /// Num�ro de t�l�phone du candidat.
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Addresse Mail du candidat.
        /// </summary>
        public string AdresseMail { get; set; }
        /// <summary>
        /// Situation Professionel du candidat.Si faux il est sans emploi.
        /// </summary>
        public bool SituationProfess { get; set; }
        /// <summary>
        /// Mobilit� du candidat. Si vrai il peux d�m�nager.
        /// </summary>
        public bool Mobilite { get; set; }
        /// <summary>
        /// Situation Familiale du candidat
        /// </summary>
        public SituationFamiliale SituationF { get; set; }
        /// <summary>
        /// Pole de Rattachement du candidat.
        /// </summary>
        public PoleEmbauche PoleRattachement { get; set; }
        /// <summary>
        /// liste des dipl�mes du candidat.
        /// </summary>
        public List<DiplomeTitre> Diplomes { get; set; }
        /// <summary>
        /// liste des Exp�riences du candidat.
        /// </summary>
        public List<Experience> Experiences { get; set; }
        /// <summary>
        /// liste des Postes recherch� par le candidat.
        /// </summary>
        public List<PosteRecherche> Postes { get; set; }

    }
}