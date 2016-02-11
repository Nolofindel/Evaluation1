using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasseurDeTetes.Dao
{
    /// <summary>
    /// Classe gérant les entreprises dans la base de donnée.
    /// </summary>
    public class DaoEntreprise
    {
        /// <summary>
        /// Méthode de récupération des entreprises d'un candidat.
        /// </summary>
        /// <returns>Est retourné la liste des entreprises.</returns>
        public static List<Metier.Entreprise> GetAllEntreprises()
        {
            List<Metier.Entreprise> Entreprises = new List<Metier.Entreprise>();
            using (SqlConnection sqlCo = DaoConnection.GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlCo;
                    String strCo = "GetAllEntreprises";
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    sqlCde.CommandText = strCo;
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            Metier.Entreprise Ent = new Metier.Entreprise();
                            Ent.IdEntreprise = sqlRdr.GetInt32(0);
                            Ent.SecteurActivite = new Metier.Activite((sbyte)sqlRdr.GetByte(1));
                            Ent.PoleRattachement = new Metier.PoleEmbauche();
                            if (!sqlRdr.IsDBNull(2)) { Ent.PoleRattachement.IdPole = sqlRdr.GetInt32(2); }
                            Ent.RaisonSociale = sqlRdr.GetString(3);
                            Ent.Adresse1Ent = sqlRdr.GetString(4);
                            if (!sqlRdr.IsDBNull(5)){Ent.Adresse2Ent = sqlRdr.GetString(5);}
                            Ent.CpEnt = sqlRdr.GetString(6);
                            Ent.VilleEnt= sqlRdr.GetString(7);
                            Ent.Cliente= sqlRdr.GetBoolean(8);
                            if (!sqlRdr.IsDBNull(9)) { Ent.Contact = sqlRdr.GetString(9); }
                            if (!sqlRdr.IsDBNull(10)) { Ent.TelContact = sqlRdr.GetString(10); }
                            if (!sqlRdr.IsDBNull(11)) { Ent.MailContact = sqlRdr.GetString(11); }
                            Ent.DateCreation = sqlRdr.GetDateTime(12);
                            Entreprises.Add(Ent);
                        }
                        sqlRdr.Close();
                    }
                    catch (SqlException se)
                    {
                        throw new Exceptions.DaoException.DAOExceptionFinApplication("Lecture  des candidats impossible: \n" + se.Message, se);
                    }
                }
            }
            Metier.Entreprise Entn = new Metier.Entreprise();
            Entn.IdEntreprise = 0;
            Entn.RaisonSociale = "Aucune";
            Entreprises.Add(Entn);
            return Entreprises;
        }
    }
}
