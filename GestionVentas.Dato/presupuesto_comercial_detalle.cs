//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionVentas.Dato
{
    using System;
    using System.Collections.Generic;
    
    public partial class presupuesto_comercial_detalle
    {
        public presupuesto_comercial_detalle()
        {
            this.presupuesto_comercial_condicion_venta = new HashSet<presupuesto_comercial_condicion_venta>();
            this.presupuesto_comercial_resumen = new HashSet<presupuesto_comercial_resumen>();
        }
    
        public int PK_Presupuesto_Comercial_Detalle_id { get; set; }
        public int Presupuesto_Comercial { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Horas_Pareja { get; set; }
        public Nullable<int> Fletes { get; set; }
        public Nullable<int> Dias_Trabajos { get; set; }
        public Nullable<System.DateTime> Fecha_Ejecucion { get; set; }
        public string Tecnico_Asignado { get; set; }
        public Nullable<System.DateTime> Fecha_Inicio { get; set; }
        public Nullable<System.DateTime> Fecha_Termino { get; set; }
        public Nullable<int> Guia_Despacho { get; set; }
        public Nullable<int> Numero_Factura { get; set; }
        public Nullable<int> Mes_Facturacion { get; set; }
    
        public virtual presupuesto_comercial presupuesto_comercial1 { get; set; }
        public virtual ICollection<presupuesto_comercial_condicion_venta> presupuesto_comercial_condicion_venta { get; set; }
        public virtual ICollection<presupuesto_comercial_resumen> presupuesto_comercial_resumen { get; set; }
    }
}
