using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChasseurDeTetes.Dao;
using System.Data;

namespace ChasseurDeTetes.Dao
{
    /// <summary>
    /// Classe gérant les candidats dans la base de donnée.
    public class DaoCandidat
    {
        /// <summary>
        /// Méthode de récupération des candidats d'un candidat.
        /// </summary>
        /// <returns>Est retourné la liste des candidats.</returns>
        public static List<Metier.Candidat> GetAllCandidats()
        {
            List<Metier.Candidat>  listeCandidats = new List<Metier.Candidat>();
            using (SqlConnection sqlCo = DaoConnection.GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlCo;
                    String strCo = "GetAllCandidats";
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    sqlCde.CommandText = strCo;
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            listeCandidats.Add(new Metier.Candidat(sqlRdr.GetInt32(9), sqlRdr.GetString(2), sqlRdr.GetString(3), sqlRdr.GetDateTime(4), sqlRdr.GetString(5), sqlRdr.GetString(6), sqlRdr.GetBoolean(7), sqlRdr.GetBoolean(8), new Metier.SituationFamiliale((sbyte)sqlRdr.GetByte(0)), new Metier.PoleEmbauche(sqlRdr.GetInt32(1))));
                        }
                        sqlRdr.Close();
                    }
                    catch (SqlException se)
                    {
                        throw new Exceptions.DaoException.DAOExceptionFinApplication("Lecture  des candidats impossible: \n" + se.Message, se);
                    }
                    }
                }
            return listeCandidats;
        }

                
        }
    }
