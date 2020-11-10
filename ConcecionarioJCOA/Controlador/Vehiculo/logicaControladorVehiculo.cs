using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Vehiculo;

namespace Controlador.Vehiculo
{
    public class logicaControladorVehiculo
    {
        public int NegociarInsertVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tv)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();

            return negociarAcceso.InsertVehiculo(id, marca, modelo, placa, anio, id_tv);
        }
    }
}
