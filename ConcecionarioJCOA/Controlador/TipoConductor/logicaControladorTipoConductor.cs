using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.TipoConductor;

namespace Controlador.TipoConductor
{
    public class logicaControladorTipoConductor
    {
        public int NegociarInsertTipoConductor(int id, string tppersona)
        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();

            return negociarAcceso.InsertTipoConductor(id, tppersona);
        }
    }
}
