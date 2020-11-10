using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Contrato;

namespace Controlador.Contrato
{
    public class logicaControladorContrato
    {
        public int NegociarInsertContrato(int id, int id_c, int id_v)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();

            return negociarAcceso.InsertContrato(id, id_c, id_v);
        }
    }
}
