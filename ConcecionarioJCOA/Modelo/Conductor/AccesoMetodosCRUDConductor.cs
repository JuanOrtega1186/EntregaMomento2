using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class AccesoMetodosCRUDConductor
    {
        public int InsertConductor(int id, string nombre, string tplic, int id_v, int id_tc)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacInsert_c();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tplic", tplic);
            _comando.Parameters.AddWithValue("@id_v", id_v);
            _comando.Parameters.AddWithValue("@id_tc", id_tc);
            

            return MetodosCRUDConductor.EjecutarComandoProceAlmacInsert_c(_comando);
        }
    }
}
