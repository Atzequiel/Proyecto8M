using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto8M.Clases
{
    internal class Consultas
    {
        static Conexion con = new Conexion();
        static MySqlConnection conn;

        public static Image getImagen(string id)
        {
            try
            {
                conn = con.openCon();

                string sql = "SELECT imagen FROM Imagen WHERE imagen_id = ?";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("?", id);

                MySqlDataReader dr = cmd.ExecuteReader();

                string imagen = null;
                Image img = null;

                while (dr.Read())
                {
                    imagen = (string)dr["imagen"];
                    img = Image.FromFile(imagen);
                }

                return img;

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al conseguir la imagen: " + e);
                return null;
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        public static string[] getPerfil(string id)
        {
            try
            {
                conn = con.openCon();

                string sql = "SELECT p.*, "
                    + "GROUP_CONCAT(DISTINCT o.ocupacion ORDER BY o.ocupacion SEPARATOR ', ') AS ocupaciones, "
                    + "GROUP_CONCAT(DISTINCT l.logro ORDER BY l.logro SEPARATOR ', ') AS logros " + "FROM Perfil p "
                    + "LEFT JOIN Ocupacion o ON p.id = o.perfil_id " + "LEFT JOIN Logro l ON p.id = l.perfil_id "
                    + "WHERE p.id = ? " + "GROUP BY p.id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("?", id);

                MySqlDataReader dr = cmd.ExecuteReader();

                string[] datos = new string[5];

                while (dr.Read())
                {
                    string nom1 = (string)dr["nom1"];
                    string nom2 = dr.IsDBNull(dr.GetOrdinal("nom2")) ? null : (string)dr["nom2"];
                    string ape1 = (string)dr["ape1"];
                    string ape2 = dr.IsDBNull(dr.GetOrdinal("ape2")) ? null : (string)dr["ape2"];
                    string nomCompleto = unirNombres(nom1, nom2, ape1, ape2);
                    string fechaNac = dr.GetDateTime("fechaNac").ToString("d");
                    string fechaFall = dr.GetDateTime("fechaFall").ToString("d");
                    string nacionalidad = (string)dr["nacionalidad"];
                    string ocupacion = (string)dr["ocupaciones"];
                    string logro = (string)dr["logros"];

                    //datos = $"Nombre: {nomCompleto} :: {fechaNac} - {fechaFall} :: Nacionalidad: {nacionalidad} :: Ocupación: {ocupacion} :: Logró: {logro}";

                    datos[0] = $"Nombre: {nomCompleto}";
                    datos[1] = $"{fechaNac} - {fechaFall}";
                    datos[2] = $"Nacionalidad: {nacionalidad}";
                    datos[3] = $"Ocupacion/es: {ocupacion}";
                    datos[4] = $"Logró: {logro}";
                }

                return datos;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conseguir datos: " + e);
                return null;
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        public static double getPromedioEdades(string nacionalidad)
        {
            try
            {
                conn = con.openCon();

                string sql = "SELECT datediff(fechaFall, fechaNac) AS dias FROM perfil WHERE nacionalidad = ?";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("?", nacionalidad);

                MySqlDataReader dr = cmd.ExecuteReader();

                int dias = 0;
                int sumaDias = 0;
                int totalPersonas = 0;

                while (dr.Read())
                {
                    if (!dr.IsDBNull(dr.GetOrdinal("dias")))
                    {
                        dias = dr.GetInt32("dias");
                        sumaDias += dias;
                        totalPersonas++;
                    }
                }

                double promedioEdades = ((double)sumaDias / 365) / totalPersonas;

                return promedioEdades;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conseguir datos: " + e);
                return 0;
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        public static string unirNombres(string nom1, string nom2, string ape1, string ape2)
        {
            StringBuilder nombreCompleto = new StringBuilder();

            nombreCompleto.Append(nom1 + " ");

            if (nom2 != null)
            {
                nombreCompleto.Append(nom2 + " ");
            }

            nombreCompleto.Append(ape1 + " ");

            if (ape2 != null)
            {
                nombreCompleto.Append(ape2 + " ");
            }

            return nombreCompleto.ToString().Trim();
        }
    }
}
