using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionVenta.View.Layout
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_LOGIN_Click(object sender, EventArgs e)
        {
            inputEmail.Value.ToString();
            inputPassword.Value.ToString();
            Response.Redirect("Cotizacion.aspx");
        }
    }
}