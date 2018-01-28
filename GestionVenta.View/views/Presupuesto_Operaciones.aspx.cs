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


    }
}