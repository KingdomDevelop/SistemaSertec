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
    
    public partial class presupuesto_comercial_condicion_venta
    {
        public int PK_ppto_comercial_condicion_venta_id { get; set; }
        public int Presupuesto_Comercial { get; set; }
        public Nullable<bool> Porcentaje_Cinco { get; set; }
        public Nullable<bool> Porcentaje_Quince { get; set; }
        public Nullable<bool> Porcentaje_Otro { get; set; }
        public Nullable<int> Valor_Porcentaje_Otro { get; set; }
        public Nullable<bool> Pago_Completo_Termino_Trabajo { get; set; }
        public Nullable<bool> Pago_Incompleto_Termino_Trabajo { get; set; }
        public Nullable<bool> Cuotas { get; set; }
        public Nullable<int> Numero_Cuotas { get; set; }
        public Nullable<bool> Otro_Descuento { get; set; }
        public Nullable<bool> Copia_Presupuesto_Firmado { get; set; }
        public Nullable<bool> Orden_Compra { get; set; }
        public Nullable<bool> Otro_Medio { get; set; }
        public string Descripcion_Otro_Medio { get; set; }
    
        public virtual presupuesto_comercial_detalle presupuesto_comercial_detalle { get; set; }
    }
}
