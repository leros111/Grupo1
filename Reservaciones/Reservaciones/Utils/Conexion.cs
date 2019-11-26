using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Reservaciones.Utils
{
    class Conexion
    {
        public static MySqlConnection GetConnection()
        {
            const string SERVER = "localhost";
            const string DATABASE = "sistema_rsv";
            const string UID = "root";
            const string PWD = "";
            string connectionString = $"server{SERVER}; database={DATABASE}; Uid={UID}; Pwd={PWD}";

            MySqlConnection cn = new MySqlConnection(connectionString);

            cn.Open();

            return cn;
        }
    }
}
