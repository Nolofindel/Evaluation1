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
    /// Classe gérant les Qualifications dans la base de donnée.
    /// </summary>
    public class DaoQualifications
    {
        /// <summary>
        /// Méthode de récupération des qualifications.
        /// </summary>
        /// <returns>Est retourné la liste des qualifications.</returns>
        public static List<Metier.Qualification> GetAllQualifications()
        {
            List<Metier.Qualification> Qualifications = new List<Metier.Qualification>();
            using (SqlConnection sqlCo = DaoConnection.GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlCo;
                    String strCo = "GetAllQualifications";
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    sqlCde.CommandText = strCo;
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            Metier.Qualification Qual = new Metier.Qualification(sqlRdr.GetInt32(0));
                            Qual.LibelleQualification = sqlRdr.GetString(1);
                            Qualifications.Add(Qual);
                        }
                        sqlRdr.Close();
                    }
                    catch (SqlException se)
                    {
                        throw new Exceptions.DaoException.DAOExceptionFinApplication("Lecture  des candidats impossible: \n" + se.Message, se);
                    }
                }
            }
            return Qualifications;
        }
    }
}
