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
    
    public partial class usuario
    {
        public int PK_UsuarioID { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<int> PK_PersonaID { get; set; }
    
        public virtual persona persona { get; set; }
    }
}
