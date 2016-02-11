using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasseurDeTetes.Exceptions
{
    /// <summary>
    /// Classe des Exceptions liées à la base de donnée.
    /// </summary>
    class DaoException:Exception
    {
        public DaoException(): base()
        {
        }

        public DaoException(string message) : base(message)
        {
        }

        public DaoException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Exeption gérant les fin d'application.
        /// </summary>
        public class DAOExceptionFinApplication : DaoException
        {

            public DAOExceptionFinApplication():base()
            {                
            }

            public DAOExceptionFinApplication(string message) : base(message)
            {
            }

            public DAOExceptionFinApplication(string message, System.Exception inner) : base(message,inner)
            {
            }
        }
    }
}
