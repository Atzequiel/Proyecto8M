using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8M.Clases
{
    internal class Conexion
    {
        MySqlConnection con = new MySqlConnection();

        static string bd = "ProgYBD";
        static string user = "root";
        static string passwd = "root";
        static string server = "localhost";
        static string port = "3306";

        string conString = $"Server={server};Port= {port};Database={bd};Uid={user};Pwd={passwd};";

        public MySqlConnection createCon()
        {
            try
            { 
                con.ConnectionString = conString;
                con.Open();
                Console.WriteLine($"Base de datos {bd}: OK");
                return con;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se pudo conectar a la BD: " + ex.ToString());
                return null;
            }
        }
    }
}
