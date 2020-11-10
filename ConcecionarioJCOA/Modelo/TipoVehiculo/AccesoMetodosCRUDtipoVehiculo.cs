using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class AccesoMetodosCRUDtipoVehiculo
    {
        //Crear operacion INSERT

        public int InsertTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacInsert_tv();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProceAlmacInsert_tv(_comando);
        }

    }
}
