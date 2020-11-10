using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Ruta;

namespace Vista
{
    public partial class gestRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idruta = Int32.Parse(txtId.Text);
            string estacion = txtIdEstac.Text;
            int idvehiculo = Int32.Parse(txtIdVeh.Text);

            logicaControladorRuta negocioAddRuta = new logicaControladorRuta();

            int resultadoAddRuta = negocioAddRuta.NegociarInsertRuta(idruta, estacion, idvehiculo);

            if (resultadoAddRuta > 0)
                lblMensaje.Text = "Registro OK";
            else
                lblMensaje.Text = "No se pudo Registrar";

            negocioAddRuta = null;
        }
    }
}