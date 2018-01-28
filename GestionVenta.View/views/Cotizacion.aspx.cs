using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.Negocio.Implementacion;
using GestionVentas.Negocio.Mappers;
using GestionVentas.Negocio.Dto;
using System.Web.UI.HtmlControls;

namespace GestionVenta.View.Layout
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {

        protected TextBox td_uf_id = new TextBox();

        protected TextBox td_hp_id = new TextBox();

        protected TextBox td_flete_id = new TextBox();

        protected TextBox td_fecha = new TextBox();



        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.Page.IsPostBack)
            {
                CargaVariables();
            }




        }


        public void CargaVariables()
        {

            //td_flete_id.Value = "1";
            //td_flete.Value = "12";

            //td_fecha.Value = DateTime.Now.ToString("{0:M/d/yyyy}");

            //td_hp.Value = "1";
            //td_hp_id.Value = "1";

            //td_uf.Value = "1";
            //td_uf_id.Text = "1";

            td_uf_id.Text = "1";
            td_hp_id.Text = "1";
            td_flete_id.Text = "1";

            DateTime DiaActual = DateTime.Now;
            td_fecha.Text = DateTime.Now.ToString("d/M/yyyy");
        }

        public void ObtenerData()
        {

            //llamamos al objeto Presupuesto
            string myStringFromTheInput = td_obra.Value;
            td_obra.Value="Esto es una prueba de codigo";



        }

        public void BorrarData()
        {

            //llamamos al objeto Presupuesto
            string myStringFromTheInput = td_obra.Value;
            td_obra.Value = "";
        }

        public void rellenardatos() {
            var obtLista = new PresupuestoSvcImpl();
            obtLista.obtenerPresupuestos();

        }

        protected void btn_agregarRepuesto_Click(object sender, EventArgs e)
        {
            //  ObtenerData();
            rellenardatos();
        }

        protected void btn_quitarRepuesto_Click(object sender, EventArgs e)
        {
            BorrarData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var ppto = new PresupuestoSvcImpl();
            var info = new PresupuestoDto();
            var NewPto = new PresupuestoOrdenTrabajoDto();
            var NewPtoRep = new PresupuestoRepuestoDto();
            var NewPtoTer = new PresupuestoTercerosDto();
            var NewPtoResumen = new PresupuestoTrabajoResumenDto();


            info.FechaEmision = Convert.ToDateTime(td_fecha.Text);
            info.ValorFlete = Convert.ToInt16(td_flete_id.Text);
            info.ValorHH = Convert.ToInt16(td_hp_id.Text);
            info.ValorMoneda = Convert.ToInt16(td_uf_id.Text);
            info.Descripcion = tf_detalleArea.Value.ToString();// tf_detalle.Text;


            var idCot = ppto.guardarPresupuesto(info);

            // NewPto.PresupuestoOrdenTrabajoId AutoIncrementable
            NewPto.Presupuesto = idCot;
            NewPto.Obra = td_obra.Value;
            NewPto.Fecha = DateTime.Now;
            NewPto.Ascensor = td_asc.Text;
            NewPto.TecnicoEmisor = td_tec.Text;
            NewPto.Supervisor = td_sup.Text;
            NewPto.Descripcion = tf_detalleArea.Value.ToString();
            NewPto.DescripcionTerceros = tf_terceros.Text;
            NewPto.Direccion = "Direccion 2040 Gatito";
            NewPto.TelefonoContacto =111111111;
            NewPto.FechaAprobacion = DateTime.Now;

            var Result = ppto.guardarPresupuestoOrdenTrabajo(NewPto);

            NewPtoRep.Presupuesto = idCot;
            NewPtoRep.Repuesto = 1;
            NewPtoRep.Cantidad = Convert.ToInt32(tf_cantidad.Text);
            NewPtoRep.Codigo=Convert.ToInt32(tf_codigo.Text);
            NewPtoRep.ValorUnitario = Convert.ToInt32(tf_valor.Text);
            NewPtoRep.SubTotal = Convert.ToInt32(tf_subtotal.Text);
            NewPtoRep.HoraParHombre = Convert.ToInt32(tf_hp2);

            var ResultPre = ppto.guardarPresupuestoRepuesto(NewPtoRep);

            
            NewPtoTer.Presupuesto = idCot;
            NewPtoTer.Descripcion = tf_terceros.Text;
            NewPtoTer.Valor = Convert.ToInt32(tf_valter.Text);


            var ResultTerc = ppto.guardarPresupuestoTerceros(NewPtoTer);

            NewPtoResumen.Presupuesto = idCot;

           var resumenId = ppto.guardarPresupuestoResumen(NewPtoResumen);

            var NewResumenMoDetalle = new PresupuestoResumenMoDetalleDto();
            NewResumenMoDetalle.PresupuestoTrabajoResumen = resumenId;
           // NewResumenMoDetalle.HorasParejas = 

        }


        public void AgregarPrimerGrupo()
        {

        }

        protected void td_fecha_TextChanged(object sender, EventArgs e)
        {
            if (EsFecha(td_fecha.Text) == false)
            {  }

        }

        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
               
                return false;
            }
        }
    }
}