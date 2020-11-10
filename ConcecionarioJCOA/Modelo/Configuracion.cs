using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Configuracion
    {
        static string cadenaConexion = @"Data Source=DESKTOP-7MOBEOP\SQLEXPRESS; Initial Catalog=Concesionario; True_Connection=true";

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
