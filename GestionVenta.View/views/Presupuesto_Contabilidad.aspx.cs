using GestionVentas.Negocio.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionVenta.View.Layout
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Datos()
        {
            var ppto = new PresupuestoSvcImpl();

            //aqui llamo al metodo que necesito


        }
    }
}