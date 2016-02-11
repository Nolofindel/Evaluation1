using System;
using System.Collections.Generic;

namespace ChasseurDeTetes.Metier
{
    /// <summary>
    /// Classe de la Qualification.
    /// </summary>
    public class Qualification
    {
        public Qualification(int idQualification)
        {
            IdQualification = idQualification;
        }
        /// <summary>
        /// Id de la qualification.
        /// </summary>
        public int IdQualification { get; set; }
        /// <summary>
        /// Nom de la qualification.
        /// </summary>
        public string LibelleQualification { get; set; }
        /// <summary>
        /// Liste des Postes Recherchés.
        /// </summary>
        public List<PosteRecherche> Postes { get; set; }
        /// <summary>
        /// Renvoie de la QUalification.
        /// </summary>
        public Qualification Self
        {
            get { return this; }
        }
        /// <summary>
        /// Test d'égalité de la qualification avec une autre.
        /// </summary>
        /// <param name="o">Qualification.</param>
        /// <returns>Si vrai, les qualifications sont les mêmes.Sinon elles sont différentes.</returns>
        public override bool Equals(Object o)
        {
            if (o is Qualification && ((Qualification)o).IdQualification == IdQualification) { return true; }
            return false;
        }
    }
}