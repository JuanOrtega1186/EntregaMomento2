using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Vehiculo;

namespace Vista
{
    public partial class gestVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idvehiculo = Int32.Parse(txtId.Text);
            string marcavehiculo = txtMarca.Text;
            string modelovehiculo = txtModelo.Text;
            string placavehiculo = txtPlaca.Text;
            int aniovehiculo = Int32.Parse(txtanio.Text);
            int idtpvehiculo = Int32.Parse(txtidtp.Text);

            logicaControladorVehiculo negocioAddVehiculo = new logicaControladorVehiculo();

            int resultadoAddVehiculo = negocioAddVehiculo.NegociarInsertVehiculo(idvehiculo, marcavehiculo, modelovehiculo, placavehiculo, aniovehiculo, idtpvehiculo);

            if (resultadoAddVehiculo > 0)
                lblMensaje.Text = "Registro OK";
            else
                lblMensaje.Text = "No se pudo Registrar";

            negocioAddVehiculo = null;
        }
    }
}