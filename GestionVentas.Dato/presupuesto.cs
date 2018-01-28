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
    
    public partial class presupuesto
    {
        public presupuesto()
        {
            this.presupesto_repuesto = new HashSet<presupuesto_repuesto>();
            this.presupuesto_trabajo_resumen = new HashSet<presupuesto_trabajo_resumen>();
            this.presupuesto_comercial = new HashSet<presupuesto_comercial>();
            this.presupuesto_orden_trabajo = new HashSet<presupuesto_orden_trabajo>();
            this.presupuesto_trabajo_terceros = new HashSet<presupuesto_trabajo_terceros>();
        }
    
        public int PK_Presupuesto_id { get; set; }
        public string Presupuesto_descripcion { get; set; }
        public int Valor_moneda { get; set; }
        public sbyte Valor_HH { get; set; }
        public sbyte Valor_Flete { get; set; }
        public System.DateTime Fecha_Emision { get; set; }
    
        public virtual moneda moneda { get; set; }
        public virtual ICollection<presupuesto_repuesto> presupesto_repuesto { get; set; }
        public virtual ICollection<presupuesto_trabajo_resumen> presupuesto_trabajo_resumen { get; set; }
        public virtual ICollection<presupuesto_comercial> presupuesto_comercial { get; set; }
        public virtual ICollection<presupuesto_orden_trabajo> presupuesto_orden_trabajo { get; set; }
        public virtual ICollection<presupuesto_trabajo_terceros> presupuesto_trabajo_terceros { get; set; }
        public virtual valor_esfuerzo valor_esfuerzo { get; set; }
        public virtual valor_esfuerzo valor_esfuerzo1 { get; set; }
    }
}