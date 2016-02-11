using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasseurDeTetes.Dao
{

    static class Extensions
    {
        public static SqlParameter AddWithNullableValue(this SqlParameterCollection collection, string parameterName, object value)
        {
            if (value == null || (value is string && ((string)value == string.Empty)) || (value is int && ((int)value == 0)))
                return collection.AddWithValue(parameterName, DBNull.Value);
            else
                return collection.AddWithValue(parameterName, value);
        }

       
    }
}
