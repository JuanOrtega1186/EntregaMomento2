using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.TipoConductor;

namespace Vista
{
    public partial class gestTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idtipoconductor = Int32.Parse(txtId.Text);
            string tipopersona = txttipop.Text;

            logicaControladorTipoConductor negocioAddTipoConductor = new logicaControladorTipoConductor();

            int resultadoAddTipoConductor = negocioAddTipoConductor.NegociarInsertTipoConductor(idtipoconductor, tipopersona);

            if (resultadoAddTipoConductor > 0)
                lblMensaje.Text = "Registro OK";
            else
                lblMensaje.Text = "No se pudo Registrar";

            negocioAddTipoConductor = null;
        }
    }
}