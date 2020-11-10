using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class MetodosCRUDConductor
    {
        public static SqlCommand CrearComandoProcAlmacInsert_c()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addConductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando
        public static int EjecutarComandoProceAlmacInsert_c(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
