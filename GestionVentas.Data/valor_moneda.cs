//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionVentas.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class valor_moneda
    {
        public valor_moneda()
        {
            this.presupuesto = new HashSet<presupuesto>();
        }
    
        public int idValor_Moneda { get; set; }
        public decimal Valor_UF { get; set; }
        public int Valor_HP { get; set; }
        public int Valor_Flete { get; set; }
        public System.DateTime Fecha_UF { get; set; }
        public sbyte Estado { get; set; }
    
        public virtual ICollection<presupuesto> presupuesto { get; set; }
    }
}
