using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Conductor;

namespace Vista
{
    public partial class gestConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idconductor = Int32.Parse(txtId.Text);
            string nombreconductor = txtNombreC.Text;
            string tipolicencia = txttplic.Text;
            int idvehiculo = Int32.Parse(txtidveh.Text);
            int idtipoconductor = Int32.Parse(txtidtpc.Text);

            logicaControladorConductor negocioAddConductor = new logicaControladorConductor();

            int resultadoAddConductor = negocioAddConductor.NegociarInsertConductor(idconductor, nombreconductor, tipolicencia, idvehiculo, idtipoconductor);

            if (resultadoAddConductor > 0)
                lblMensaje.Text = "Registro OK";
            else
                lblMensaje.Text = "No se pudo Registrar";

            negocioAddConductor = null;
        }
    }
}