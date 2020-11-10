using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Ruta;

namespace Controlador.Ruta
{
    public class logicaControladorRuta
    {
        public int NegociarInsertRuta(int id, string estacion, int id_v)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.InsertRuta(id, estacion, id_v);
        }
    }
}
