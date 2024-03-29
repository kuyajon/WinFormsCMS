using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCMS
{
    public class DbUtils
    {
        public static string DATABASE_CONNECTION_STRING = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public static IDbConnection getConnection()
        {
            IDbConnection cnn = new MySqlConnection(DATABASE_CONNECTION_STRING);
            cnn.Open();
            return cnn;
        }
    }
}
