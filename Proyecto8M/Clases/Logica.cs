using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8M.Clases
{
    internal class Logica
    {
        public static string[] getPerfil(string id)
        {
            return Clases.Consultas.getPerfil(id);
        }

        public static string getImagen(string id)
        {
            return Clases.Consultas.getImagen(id);
        }
    }
}
