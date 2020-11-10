using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Contrato;

namespace Vista
{
    public partial class gestContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idcontrato = Int32.Parse(txtId.Text);
            int idconductor = Int32.Parse(txtIdCond.Text);
            int idvehiculo = Int32.Parse(txtIdVeh.Text);

            logicaControladorContrato negocioAddContrato = new logicaControladorContrato();

            int resultadoAddContrato = negocioAddContrato.NegociarInsertContrato(idcontrato, idconductor, idvehiculo);

            if (resultadoAddContrato > 0)
                lblMensaje.Text = "Registro OK";
            else
                lblMensaje.Text = "No se pudo Registrar";

            negocioAddContrato = null;
        }
    }
}