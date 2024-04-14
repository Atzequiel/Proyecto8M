using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8M.Clases
{
    internal class Logica
    {
        public static Image getImagen(string id)
        {
            return Clases.Consultas.getImagen(id);
        }

        public static string[] getPerfil(string id)
        {
            return Clases.Consultas.getPerfil(id);
        }
        
        public static double getPromedioEdades(string nacionalidad)
        {
            return Clases.Consultas.getPromedioEdades(nacionalidad);
        }
        
    }
}
