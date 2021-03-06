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
    
    public partial class cotizacion
    {
        public cotizacion()
        {
            this.contabilidad = new HashSet<contabilidad>();
            this.cotizacionrepuesto = new HashSet<cotizacionrepuesto>();
            this.cotizaciontrabajoterceros = new HashSet<cotizaciontrabajoterceros>();
        }
    
        public int PK_Cotizacion_ID { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string Obra { get; set; }
        public string Ascensor { get; set; }
        public string TecnicoEmisor { get; set; }
        public string Supervisor { get; set; }
        public string PresupuestoNumero { get; set; }
        public decimal ValorUf { get; set; }
        public decimal ValorHP { get; set; }
        public Nullable<decimal> ValorFlete { get; set; }
        public Nullable<System.DateTime> FechaCalculo { get; set; }
        public string DescripcionDetalle { get; set; }
        public Nullable<int> DuracionTrabajo { get; set; }
        public Nullable<decimal> ValorMoneda { get; set; }
        public Nullable<decimal> ValorHH { get; set; }
        public Nullable<decimal> HorasParejas { get; set; }
        public Nullable<decimal> SubTotalManoObra { get; set; }
        public Nullable<decimal> RecargoHHEE { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> ValorVenta { get; set; }
        public Nullable<decimal> ValorMargenVenta { get; set; }
        public Nullable<int> CantidadFletes { get; set; }
        public Nullable<decimal> TotalFletes { get; set; }
        public Nullable<int> ValorManoObra { get; set; }
        public Nullable<int> ValorRepuestos { get; set; }
        public Nullable<int> ValorTerceros { get; set; }
        public Nullable<int> ValorTerceras { get; set; }
        public Nullable<int> ValorFletes { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> TotalNetoComisiones { get; set; }
    
        public virtual ICollection<contabilidad> contabilidad { get; set; }
        public virtual ICollection<cotizacionrepuesto> cotizacionrepuesto { get; set; }
        public virtual ICollection<cotizaciontrabajoterceros> cotizaciontrabajoterceros { get; set; }
    }
}
