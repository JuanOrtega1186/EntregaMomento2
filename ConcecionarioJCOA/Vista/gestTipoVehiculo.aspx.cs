using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.TipoVehiculo;

namespace Vista
{
    public partial class gestTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idtipovehiculo = Int32.Parse(txtId.Text);
            string nombretipovehiculo = txtNombre.Text;

            logicaControladorTipoVehiculo negocioAddTipoVehiculo = new logicaControladorTipoVehiculo();

            int resultadoAddTipoVehiculo = negocioAddTipoVehiculo.NegociarInsertTipoVehiculo(idtipovehiculo, nombretipovehiculo);

            if (resultadoAddTipoVehiculo > 0)
                lblMensaje.Text = "Registro OK";
            else
                lblMensaje.Text = "No se pudo Registrar";

            negocioAddTipoVehiculo = null;
        }
    }
}