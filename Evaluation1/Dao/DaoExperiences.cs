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
    /// Classe gérant les expériences dans la base de donnée.
    /// </summary>
    public class DaoExperiences
    {
        /// <summary>
        /// Méthode de récupération des expériences d'un candidat.
        /// </summary>
        /// <param name="Candidat">Le Candidat à qui ont récupère les expériences.</param>
        /// <returns>Est retourné la liste des expériences du candidat.</returns>
        public static List<Metier.Experience> GetAllExperiences(Metier.Candidat Candidat)
        {
            List<Metier.Experience> Experiences = new List<Metier.Experience>();
            using (SqlConnection sqlCo = DaoConnection.GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlCo;
                    String strCo = "GetAllExperiences";
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    sqlCde.CommandText = strCo;
                    sqlCde.Parameters.Add(new SqlParameter("@IdCandidat", SqlDbType.Int)).Value = Candidat.IdCandidat;
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            //Experiences.Add(new Metier.Experience(sqlRdr.GetInt32(0), sqlRdr.GetInt32(2), sqlRdr.GetDateTime(4), sqlRdr.GetDateTime(5), sqlRdr.GetString(6), new Metier.Qualification(sqlRdr.GetInt32(1)), new Metier.Entreprise(sqlRdr.GetInt32(3))));
                            Metier.Experience Exp = new Metier.Experience();
                            Exp.IdExperience = sqlRdr.GetInt32(0);
                            Exp.IdCandidat = sqlRdr.GetInt32(2);
                            Exp.LaQualif = new Metier.Qualification(sqlRdr.GetInt32(1));
                            if (!sqlRdr.IsDBNull(3))
                            {
                                Exp.Lentreprise = new Metier.Entreprise(sqlRdr.GetInt32(3));
                            }
                            Exp.DateDebut = sqlRdr.GetDateTime(4);
                            if (!sqlRdr.IsDBNull(5))
                            {
                                Exp.DateFin = sqlRdr.GetDateTime(5);
                            }
                            if (!sqlRdr.IsDBNull(6))
                            {
                                Exp.Commentaire = sqlRdr.GetString(6);
                            }
                            Experiences.Add(Exp);
                        }
                        sqlRdr.Close();
                    }
                    catch (SqlException se)
                    {
                        throw new Exceptions.DaoException.DAOExceptionFinApplication("Lecture  des candidats impossible: \n" + se.Message, se);
                    }
                }
            }
            return Experiences;
        }
      
        /// <summary>
        /// Suppression d'une expérience dans la base de données.
        /// </summary>
        /// <param name="exp">expérience supprimée.</param>
        /// <returns>booléen indiquant si la suppression c'est faite.</returns>
        public static bool DelExperience(Metier.Experience exp)
        {
            SqlConnection sqlConnect = DaoConnection.GetConnection();
            SqlCommand sqlCde = new SqlCommand();
            sqlCde.CommandType = CommandType.StoredProcedure;
            sqlCde.CommandText = "DelExperience";
            sqlCde.Connection = sqlConnect;
            sqlCde.Parameters.AddWithValue("@idExperience", exp.IdExperience);
            int l = sqlCde.ExecuteNonQuery();
            sqlConnect.Close();
            if (l == 1)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Modification d'une expérience dans la base de données.
        /// </summary>
        /// <param name="exp">expérience modifiée.</param>
        /// <returns>booléen indiquant si la modification c'est faite.</returns>
        public static bool UpdExperience(Metier.Experience exp)
        {
            SqlConnection sqlConnect = DaoConnection.GetConnection();
            SqlCommand sqlCde = new SqlCommand();
            sqlCde.CommandType = CommandType.StoredProcedure;
            sqlCde.CommandText = "UpdExperience";
            sqlCde.Connection = sqlConnect;
            sqlCde.Parameters.AddWithValue("@IdExperience", exp.IdExperience);
            sqlCde.Parameters.AddWithValue("@idQualification", exp.LaQualif.IdQualification);
            sqlCde.Parameters.AddWithNullableValue("@idEntreprise", exp.Lentreprise.IdEntreprise);
            sqlCde.Parameters.AddWithValue("@DateDebut", exp.DateDebut);
            sqlCde.Parameters.AddWithNullableValue("@DateFin", exp.DateFin);
            sqlCde.Parameters.AddWithNullableValue("@Commentaire", exp.Commentaire);
            int l = sqlCde.ExecuteNonQuery();
            sqlConnect.Close();
            if (l == 1)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Ajout d'une expérience dans la base de données.
        /// </summary>
        /// <param name="exp">expérience ajoutée.</param>
        /// <returns>booléen indiquant si l'ajout c'est fait.</returns>
        public static bool AddExperience(Metier.Experience exp)
        {
            SqlConnection sqlConnect = DaoConnection.GetConnection();
            SqlCommand sqlCde = new SqlCommand();
            sqlCde.CommandType = CommandType.StoredProcedure;
            sqlCde.CommandText = "AddExperience";
            sqlCde.Connection = sqlConnect;
            sqlCde.Parameters.AddWithValue("@idQualification", exp.LaQualif.IdQualification);
            sqlCde.Parameters.AddWithValue("@idCandidat",exp.IdCandidat);
            sqlCde.Parameters.AddWithNullableValue("@idEntreprise", exp.Lentreprise.IdEntreprise);
            sqlCde.Parameters.AddWithValue("@DateDebut", exp.DateDebut);
            sqlCde.Parameters.AddWithNullableValue("@DateFin", exp.DateFin);
            sqlCde.Parameters.AddWithNullableValue("@Commentaire", exp.Commentaire);
            SqlParameter p = new SqlParameter("@idExperience", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
            sqlCde.Parameters.Add(p);
            int l = sqlCde.ExecuteNonQuery();
            int expcode = (int)sqlCde.Parameters[6].Value;            
            exp.IdExperience = expcode;            
            sqlConnect.Close();
            if (l == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
