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
    
    public partial class operaciones
    {
        public int PK_Operaciones_ID { get; set; }
        public Nullable<System.DateTime> FechaTecnico { get; set; }
        public string NumeroGuia { get; set; }
        public string Tecnico { get; set; }
        public string Supervisor { get; set; }
        public Nullable<System.DateTime> FechaSupervisor { get; set; }
        public Nullable<int> Ventas { get; set; }
        public Nullable<System.DateTime> FechaVentas { get; set; }
        public Nullable<int> PK_ContabilidadID { get; set; }
    
        public virtual contabilidad contabilidad { get; set; }
    }
}
