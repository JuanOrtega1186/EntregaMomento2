using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class AccesoMetodosCRUDVehiculo
    {
        //Crear operacion INSERT

        public int InsertVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tv)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacInsert_v();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);

            return MetodosCRUDVehiculo.EjecutarComandoProceAlmacInsert_v(_comando);
        }




    }
}
