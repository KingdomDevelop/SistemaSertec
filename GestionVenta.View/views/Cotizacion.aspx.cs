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
using System.Data;
using System.Net;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

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
                 this.BindGrid();

                //    // HTTP Post
                //}
                //else
                //{
                //    // HTTP Get


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

        private void BindGrid()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt.Columns.Add("NameRep");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Valor");
            dt.Columns.Add("SubTotal");
            dt.Columns.Add("HP");

            dt2.Columns.Add("TrapTer");
            dt2.Columns.Add("Valor");

            DataRow workRow = dt.NewRow();
            DataRow workRow2 = dt2.NewRow();

            workRow[0] = "Smith";
            workRow[1] = "Smith";
            workRow[2] = "Smith";
            workRow[3] = "Smith";
            workRow[4] = "Smith";
            workRow[5] = "Smith";
            workRow2[0] = "DATO ONE";
            workRow2[1] = "DATO TO";

            dt.Rows.Add(workRow);
            dt2.Rows.Add(workRow2);

            GridViewAgregarRep.DataSource = dt;
            GridViewAgregarRep.DataBind();

            GridViewAgregarTrabTer.DataSource = dt2;
            GridViewAgregarTrabTer.DataBind();
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
            obtLista.obtenerPresupuestos(1);

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
            var NewPtoResumenDet = new PresupuestoResumenMoDetalleDto();
            var NewPtoTRComDetalle = new PresupuestoTRComisionDetalleDto();

            //guardarPresupuestoResumen
            //guardarPresupuestoResumenMoDetalle
            //guardarPresupuestoTrabajoComisionDetalle

            //NewPtoResumen
            //ppto.guardarPresupuestoResumen

            //NewPtoResumenDet
            //ppto.guardarPresupuestoResumenMoDetalle

            //NewPtoTRComDetalle
            //ppto.guardarPresupuestoTrabajoComercialDetalle

            //formCotizacion.Controls.ToString();

            string[] controls = Request.Form.AllKeys;
            string value = Request.Form["tf"];

            foreach (Control _textbox in formCotizacion.Controls)
            {
                string a=  _textbox.ToString();
                string b = _textbox.ClientID.ToString();
                string c = _textbox.ID.ToString();

            }

            //HtmlTableRow tr = TabRepRep.FindControl("tr") as HtmlTableRow;
            //HtmlTableCell td = tr.FindControl("td") as HtmlTableCell;

            //foreach (System.Web.UI.HtmlControls.HtmlTableRow us in tab.Rows)
            //{
            //    string txt = us.Cells[0].InnerText;
            //}

            info.FechaEmision = Convert.ToDateTime(td_fecha.Text);
            info.ValorFlete = Convert.ToInt16(td_flete_id.Text);
            info.ValorHH = Convert.ToInt16(td_hp_id.Text);
            info.ValorMoneda = Convert.ToInt16(td_uf_id.Text);
            //info.Descripcion = tf_detalleArea.Value.ToString();// tf_detalle.Text;


            var idCot = ppto.guardarPresupuesto(info);

            // NewPto.PresupuestoOrdenTrabajoId AutoIncrementable
            NewPto.Presupuesto = idCot;
            NewPto.Obra = td_obra.Value;
            NewPto.Fecha = DateTime.Now;
            NewPto.Ascensor = td_asc.Text;
            NewPto.TecnicoEmisor = td_tec.Text;
            NewPto.Supervisor = td_sup.Text;
            NewPto.Descripcion = tf_detalleArea.Value.ToString();
            //NewPto.DescripcionTerceros = tf_terceros.Text;
            NewPto.Direccion = "Direccion 2040 Gatito";
            NewPto.TelefonoContacto =111111111;
            NewPto.FechaAprobacion = DateTime.Now;

            var Result = ppto.guardarPresupuestoOrdenTrabajo(NewPto);

            NewPtoRep.Presupuesto = idCot;
            NewPtoRep.Repuesto = "asda";
            //NewPtoRep.Cantidad = Convert.ToInt32(tf_cantidad.Text);
            //NewPtoRep.Codigo=Convert.ToInt32(tf_codigo.Text);
            //NewPtoRep.ValorUnitario = Convert.ToInt32(tf_valor.Text);
            //NewPtoRep.SubTotal = Convert.ToInt32(tf_subtotal.Text);
            //NewPtoRep.HoraParHombre = Convert.ToInt32(tf_hp2);

            var ResultPre = ppto.guardarPresupuestoRepuesto(NewPtoRep);

            
            NewPtoTer.Presupuesto = idCot;
            //NewPtoTer.Descripcion = tf_terceros.Text;
            //NewPtoTer.Valor = Convert.ToInt32(tf_valter.Text);


            var ResultTerc = ppto.guardarPresupuestoTerceros(NewPtoTer);

            NewPtoResumen.Presupuesto = idCot;

           var resumenId = ppto.guardarPresupuestoResumen(NewPtoResumen);

            var NewResumenMoDetalle = new PresupuestoResumenMoDetalleDto();
            NewResumenMoDetalle.PresupuestoTrabajoResumen = resumenId;
           // NewResumenMoDetalle.HorasParejas = 

        }

        protected void BtnAgregarRep_Click(object sender, EventArgs e)
        {

            //string name = txtName.Text;
            //string country = txtCountry.Text;
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Customers_CRUD"))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Action", "INSERT");
            //        cmd.Parameters.AddWithValue("@Name", name);
            //        cmd.Parameters.AddWithValue("@Country", country);
            //        cmd.Connection = con;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}
            this.BindGrid();
        }

        protected void BtnAgregarTrapTer_Click(object sender, EventArgs e)
        {

        }


        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewAgregarRep.EditIndex = e.NewEditIndex;

            GridViewAgregarTrabTer.EditIndex = e.NewEditIndex;
            
            this.BindGrid();
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            GridViewRow row = GridViewAgregarRep.Rows[e.RowIndex];

            GridViewRow row2 = GridViewAgregarTrabTer.Rows[e.RowIndex];
            //int customerId = Convert.ToInt32(GridViewAgregarRep.DataKeys[e.RowIndex].Values[0]);
            //string name = (row.FindControl("txtName") as TextBox).Text;
            //string country = (row.FindControl("txtCountry") as TextBox).Text;
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Customers_CRUD"))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Action", "UPDATE");
            //        cmd.Parameters.AddWithValue("@CustomerId", customerId);
            //        cmd.Parameters.AddWithValue("@Name", name);
            //        cmd.Parameters.AddWithValue("@Country", country);
            //        cmd.Connection = con;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}
            GridViewAgregarRep.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridViewAgregarRep.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //int customerId = Convert.ToInt32(GridViewAgregarRep.DataKeys[e.RowIndex].Values[0]);
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Customers_CRUD"))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Action", "DELETE");
            //        cmd.Parameters.AddWithValue("@CustomerId", customerId);
            //        cmd.Connection = con;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}
            this.BindGrid();
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridViewAgregarRep.EditIndex)
            {
              //  (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
            }

            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridViewAgregarTrabTer.EditIndex)
            {
                //  (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
            }
        }


    }
}