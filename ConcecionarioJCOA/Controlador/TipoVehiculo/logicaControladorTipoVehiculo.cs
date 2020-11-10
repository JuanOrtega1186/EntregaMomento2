using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.TipoVehiculo;

namespace Controlador.TipoVehiculo
{
    public class logicaControladorTipoVehiculo
    {
        //Negociar INSERT
        public int NegociarInsertTipoVehiculo(int id, string nombre)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.InsertTipoVehiculo(id, nombre);
        }
    }
}
