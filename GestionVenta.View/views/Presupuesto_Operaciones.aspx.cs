using GestionVentas.Negocio.Dto;
using GestionVentas.Negocio.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace GestionVenta.View.Layout
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        String _SelectDropList;
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenoGrid();
        }

        public void LlenoGrid()
        {
            List<string> TodoRepuestos = new List<string>();

            List<KeyValuePair<int, string>> datos = new List<KeyValuePair<int, string>>()

                {
                    new KeyValuePair<int, string> (2, "2"),
                    new KeyValuePair<int, string> (3, "3")
                };

            //Indicamos cúales van a ser los datos a asociar

            DropDownListPresupuestos.DataSource = datos;

            //Definimos el campo que contendrá los valores para el control

            DropDownListPresupuestos.DataValueField = "Key";

            //Definimos el campo que contendrá los textos que se verán en el control

            DropDownListPresupuestos.DataTextField = "Value";

            //Enlazamos los valores de los datos con el contenido del Control

            DropDownListPresupuestos.DataBind();

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

        protected void DropDownListPresupuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectDropList = DropDownListPresupuestos.SelectedItem.ToString();
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

            if (CalendarFechaApro.Value == "")
            {
                //MessageBox.ShowMessage("Favor, ingresar fecha de aprobación", this.Page);
                return;
            }
            //ppot.PresupuestoOrdenTrabajoId
            ppot.Presupuesto = 3;
            ppot.Fecha = DateTime.Now;
            ppot.Obra = TxtObra.Text;
            ppot.FechaAprobacion = Convert.ToDateTime(CalendarFechaApro.Value.ToString());// DateTime.Now;
            ppot.Ascensor = TxtAscen.Text;
            ppot.TecnicoEmisor = TxtTecEm.Text;
            ppot.Supervisor = TxtSupervisor.Text;
            ppot.Direccion = TxtDireccion.Text;
            ppot.Aprobacion = Convert.ToDateTime(CalendarFechaApro.Value.ToString());// DateTime.Now;
            ppot.TelefonoContacto = Convert.ToInt32(Txt_TELCONTA.Text);
            ppot.Descripcion = tf_detalleArea.Value.ToString();// "Descripción de Inserción";
            ppot.DescripcionTerceros = Textarea_trabTerc.Value.ToString();// "Descripcion Terceros de Inserción";

            var Result = ppto.guardarPresupuestoOrdenTrabajo(ppot);

            //ppco.PresupuestoControlOtId;

            ppco.PresupuestoOrdenTrabajo = Result;
            ppco.FechaTerminoTecnico= DateTime.Now;
            ppco.NumeroGuia = Convert.ToInt32(TxtBoxGuia.Text);
            ppco.Tecnico = TxtBoxTec.Text;
            ppco.FechaTerminoSupervisor = DateTime.Now;
            ppco.Supervisor = TxtBoxSup.Text;
            ppco.NumeroVentas = Convert.ToInt32(TxtBoxNumVen.Text);
            ppco.FechaTerminoVenta= DateTime.Now;

            ppto.guardarPresupuestoControlOt(ppco);
            //
            //ppco.Guia;
            //
            //ppor.PresupuestoOtRepId; 
            ppor.PresupuestoOrdenTrabajo = Result;
            ppor.Descripcion = "Nombre de la reparacion y/o Repuesto";
            ppor.Cantidad = 10;
            ppor.Codigo = "VC0165";

            ppto.guardarPresupuestoOtRep(ppor);

            CalendarFechaApro.Value = Convert.ToString(DateTime.Now);
            TxtObra.Text = "";
            TxtAscen.Text = "";
            TxtTecEm.Text = "";
            TxtSupervisor.Text = "";
            TxtDireccion.Text = "";
            Txt_TELCONTA.Text = "";
            tf_detalleArea.Value = "";
            Textarea_trabTerc.Value = "";
            TxtBoxGuia.Text = "";
            TxtBoxTec.Text = "";
            TxtBoxSup.Text = "";
            TxtBoxNumVen.Text = "";
            Txt_APROBPOR.Text = "";
            Txt_VENDEDOR.Text = "";
            TxtEmpresa.Text = "";
            TxtRut.Text = "";
        }
    }
}