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
    
    public partial class presupuesto_comercial_detalle
    {
        public int idpresupuesto_comercial_detalle { get; set; }
        public string Descripcion { get; set; }
        public int Horas_Pareja { get; set; }
        public int Fletes { get; set; }
        public int Dias_Trabajo { get; set; }
        public System.DateTime Fecha_Ejecucion { get; set; }
        public string Tecnico_Asignado { get; set; }
        public System.DateTime Fecha_Inicio { get; set; }
        public System.DateTime Fecha_Termino { get; set; }
        public int Guia_Despacho { get; set; }
        public int Numero_Factura { get; set; }
        public int Mes_Facturacion { get; set; }
    }
}