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
    
    public partial class contabilidaddescuentos
    {
        public Nullable<bool> Cinco { get; set; }
        public Nullable<bool> Quince { get; set; }
        public Nullable<bool> Otro { get; set; }
        public Nullable<int> ValorOtro { get; set; }
        public int PK_ContabilidadID { get; set; }
    
        public virtual contabilidad contabilidad { get; set; }
    }
}