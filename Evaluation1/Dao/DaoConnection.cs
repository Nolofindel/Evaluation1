using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasseurDeTetes.Dao
{
    /// <summary>
    /// Classe gérant les connections dans la base de donnée.
    /// </summary>
    public class DaoConnection
    {
        /// <summary>
        /// Etabli une connection avec la base de donnée.
        /// </summary>
        /// <returns>Renvoie la connection établie ou l'exception DAOExceptionFinApplication en cas d'échec.</returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConnect;
            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = "Data Source=(local);Initial Catalog = ChasseurDeTete; Integrated Security = True";
            try
                {                    
                    sqlConnect.Open();
                    return sqlConnect;
                }
                catch (SqlException se)
                {
                throw new Exceptions.DaoException.DAOExceptionFinApplication("La base est inaccessible : \n"+se.Message,se);
                }
            }

        }
    }
