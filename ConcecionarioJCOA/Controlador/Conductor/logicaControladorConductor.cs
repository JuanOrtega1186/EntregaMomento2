using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conductor;

namespace Controlador.Conductor
{
    public class logicaControladorConductor
    {
        public int NegociarInsertConductor(int id, string nombre, string tplic, int id_v, int id_tc)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.InsertConductor(id, nombre, tplic, id_v, id_tc);
        }
    }
}
