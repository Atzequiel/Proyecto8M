using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8M.Clases
{
    internal class Consultas
    {
        static Conexion con = new Conexion();
        static MySqlConnection conn;

        public static string getImagen(string id)
        {
            try
            {
                conn = con.createCon();

                string sql = "SELECT i.imagen FROM Imagen i WHERE i.id = @id";
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader dr = cmd.ExecuteReader();

                string imagen = null;

                while (dr.Read())
                {
                    imagen = dr.GetBodyDefinition("imagen");
                }

                return imagen;

            }
            catch (Exception e)
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
                conn = con.createCon();

                string sql = "SELECT p.*, "
                    + "GROUP_CONCAT(DISTINCT o.ocupacion ORDER BY o.ocupacion SEPARATOR ', ') AS ocupaciones, "
                    + "GROUP_CONCAT(DISTINCT l.logro ORDER BY l.logro SEPARATOR ', ') AS logros " + "FROM Perfil p "
                    + "LEFT JOIN Ocupacion o ON p.id = o.perfil_id " + "LEFT JOIN Logro l ON p.id = l.perfil_id "
                    + "WHERE p.id = @id " + "GROUP BY p.id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader dr = cmd.ExecuteReader();

                string[] datos = new string[5];

                while (dr.Read())
                {
                    string nom1 = dr.GetBodyDefinition("nom1");
                    string nom2 = dr.GetBodyDefinition("nom2");
                    string ape1 = dr.GetBodyDefinition("ape1");
                    string ape2 = dr.GetBodyDefinition("ape2");
                    string nomCompleto = unirNombres(nom1, nom2, ape1, ape2);
                    string fechaNac = dr.GetBodyDefinition("fechaNac");
                    string fechaFall = dr.GetBodyDefinition("fechaFall");
                    string nacionalidad = dr.GetBodyDefinition("nacionalidad");
                    string ocupacion = dr.GetBodyDefinition("ocupaciones");
                    string logro = dr.GetBodyDefinition("logros");

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
