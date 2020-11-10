using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class AccesoMetodosCRUDRuta
    {
        public int InsertRuta(int id, string estacion, int id_v)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacInsert_r();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_v", id_v);

            return MetodosCRUDRuta.EjecutarComandoProceAlmacInsert_r(_comando);
        }
    }
}
