using System.Drawing;

namespace Proyecto8M.Clases
{
    internal class Logica
    {
        public static Image getImagen(int id)
        {
            return Clases.Consultas.getImagen(id);
        }

        public static string[] getPerfil(int id)
        {
            return Clases.Consultas.getPerfil(id);
        }

        public static double getPromedioEdades(string nacionalidad)
        {
            return Clases.Consultas.getPromedioEdades(nacionalidad);
        }

    }
}
