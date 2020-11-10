using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class AccesoMetodosCRUDTipoConductor
    {
        public int InsertTipoConductor(int id, string tppersona)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoProcAlmacInsert_tc();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tppersona", tppersona);
            

            return MetodosCRUDTipoConductor.EjecutarComandoProceAlmacInsert_tc(_comando);
        }
    }
}
