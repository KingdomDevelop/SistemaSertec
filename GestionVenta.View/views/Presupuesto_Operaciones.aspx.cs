using GestionVentas.Negocio.Dto;
using GestionVentas.Negocio.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionVenta.View.Layout
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenoGrid();
        }

        public void LlenoGrid()
        {
            List<string> TodoRepuestos = new List<string>();

            TodoRepuestos.Add("");
            TodoRepuestos.Add("");
            TodoRepuestos.Add("");

            GridView_RepuestosReparacion.DataSource = TodoRepuestos;
            GridView_RepuestosReparacion.DataBind();

        }

        //protected void GridView_RepuestosReparacion_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        protected void GridView_RepuestosReparacion_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //int indice = GridView_RepuestosReparacion.EditIndex = e.NewEditIndex;

            //// loadDataToGrid();
            //GridView_RepuestosReparacion.Rows[indice].Cells[1].Enabled = false;
            //GridView_RepuestosReparacion.Rows[indice].Cells[3].Enabled = false;

        }

        protected void GridView_RepuestosReparacion_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GridView_RepuestosReparacion_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //int resultInt = 0;
            //bool resultado = new Prefijos_CN().ModificarPrefijos(new Prefijos_CN
            //{
            //    IdPrefijo = int.TryParse(this.gvPrefijos.DataKeys[e.RowIndex].Values["IdPrefijo"].ToString(), out resultInt) ? resultInt : 0,
            //    Nombre = ((TextBox)this.gvPrefijos.Rows[e.RowIndex].Cells[0].Controls[0]).Text,
            //    Descripcion = ((TextBox)this.gvPrefijos.Rows[e.RowIndex].Cells[1].Controls[0]).Text
            //});

            //if (resultado)
            //{
            //    gvPrefijos.EditIndex = -1;
            //    CargaPrefijos();
            //}
            //else
            //{

            //}
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            //GuardarPresupuestoOrdenTrabajo
            //GuardarPresupuestoControlOT
            //GuardarPresupuestoOTRep
            var ppto = new PresupuestoSvcImpl();
            //var ppor = new PresupuestoOtRepDto();
            var ppot = new PresupuestoOrdenTrabajoDto(); //1

            var ppco = new PresupuestoControlOtDto();//2
            
            var ppor = new PresupuestoOtRepDto();//3


            //ppot.PresupuestoOrdenTrabajoId
            ppot.Presupuesto = 3;
            ppot.Fecha = DateTime.Now;
            ppot.Obra = "13";
            ppot.FechaAprobacion= DateTime.Now;
            ppot.Ascensor = "1234";
            ppot.TecnicoEmisor = "Maximiliano B";
            ppot.Supervisor = "Rodrigo A";
            ppot.Direccion = "Santiago 123";
            ppot.Aprobacion = DateTime.Now;
            ppot.TelefonoContacto = 12345678;
            ppot.Descripcion = "Descripción de Inserción";
            ppot.DescripcionTerceros = "Descripcion Terceros de Inserción";

            var Result = ppto.guardarPresupuestoOrdenTrabajo(ppot);

            //ppco.PresupuestoControlOtId;

            ppco.PresupuestoOrdenTrabajo = 2;
            ppco.FechaTerminoTecnico= DateTime.Now;
            ppco.NumeroGuia = 001;
            ppco.Tecnico = "Maximiliano B";
            ppco.FechaTerminoSupervisor = DateTime.Now;
            ppco.Supervisor = "Rodrigo A";
            ppco.NumeroVentas = 0;
            ppco.FechaTerminoVenta= DateTime.Now;

            ppto.guardarPresupuestoControlOt(ppco);


            //
            //ppco.Guia;
            //


            //ppor.PresupuestoOtRepId; 
            ppor.PresupuestoOrdenTrabajo = 2;
            ppor.Descripcion = "Nombre de la reparacion y/o Repuesto";
            ppor.Cantidad = 10;
            ppor.Codigo = "VC0165";

            ppto.guardarPresupuestoOtRep(ppor);





        }
    }
}