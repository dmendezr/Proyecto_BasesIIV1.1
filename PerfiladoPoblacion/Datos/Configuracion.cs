using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Configuracion
    {
        static string cadenaConexion =
          "Data Source=RIVERA;Initial Catalog=Padron_Electoral;Integrated Security=True";

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
