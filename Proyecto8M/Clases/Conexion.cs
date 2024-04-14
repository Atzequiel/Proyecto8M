using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Proyecto8M.Clases
{
    internal class Conexion
    {
        private readonly MySqlConnection con;

        private static string bd = "ProgYBD";
        private static string user = "root";
        private static string passwd = "root";
        private static string server = "localhost";
        private static string port = "3306";

        private string conString = $"Server={server};Port={port};Database={bd};Uid={user};Pwd={passwd};";

        public Conexion()
        {
            con = new MySqlConnection(conString);
        }

        public MySqlConnection openCon()
        {
            try
            {
                con.Open();
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