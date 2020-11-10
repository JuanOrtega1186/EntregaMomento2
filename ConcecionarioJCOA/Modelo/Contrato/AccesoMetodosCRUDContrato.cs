using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class AccesoMetodosCRUDContrato
    {
        public int InsertContrato(int id, int id_c, int id_v)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacInsert_cont();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_c", id_c);
            _comando.Parameters.AddWithValue("@id_v", id_v);

            return MetodosCRUDContrato.EjecutarComandoProceAlmacInsert_cont(_comando);
        }
    }
}
