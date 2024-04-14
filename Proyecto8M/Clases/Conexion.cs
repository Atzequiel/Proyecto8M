using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Proyecto8M.Clases
{
    internal class Conexion
    {
        private readonly MySqlConnection con;

        private static readonly string bd = "ProgYBD";
        private static readonly string user = "root";
        private static readonly string passwd = "root";
        private static readonly string server = "localhost";
        private static readonly string port = "3306";

        private readonly string conString = $"Server={server};Port={port};Database={bd};Uid={user};Pwd={passwd};";

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