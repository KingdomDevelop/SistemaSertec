using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.Negocio.Implementacion;
using GestionVentas.Negocio.Dto;

namespace GestionVenta.View.Layout
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        //        IPresupuestoSvc presupuesto = new PrespuestoSvcImpl();


        public void LlenoTabla() {

            var obtLista = new PresupuestoSvcImpl();
            //obtLista.obtenerPresupuestos();

            //  var consulta = from p in obtLista.obtenerPresupuestos()
            // //  where p.PresupuestoId==15
            //   select p;

            //  obtLista.guardarPresupuesto(new PresupuestoDto { });

            obtLista.obtenerPresupuestos();

            var consulta = (from p in obtLista.obtenerPresupuestos() select new { p.Descripcion, p.FechaEmision }).ToList();

            //var query = from datos in obtLista.obtenerPresupuestos().AsEnumerable()
            //            select new
            //            {
            //              //  id = datos.Field<int>("Id"),
            //                Descripcion = datos.Descripcion,
            //                ValorFlete = datos.ValorFlete,

            //            };

            //TablaPresupuesto
            GridViewPresupuesto.DataSource = consulta;
            GridViewPresupuesto.DataBind();


        }






        protected void btn_ConsultarDato_Click(object sender, EventArgs e)
        {
            LlenoTabla();
        }

    }
}