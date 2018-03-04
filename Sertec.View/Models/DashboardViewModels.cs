using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sertec.View.Models
{
    public class CotizacionViewModel
    {
        //primera parte 
        public int PresupuestoId { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Obra { get; set; }
        public string Ascensor { get; set; }
        public string TecEmisor { get; set; }
        public string Supervisor { get; set; }
        public string PresupuestoNumero { get; set; }
        public string ValorUf { get; set; }
        public string ValorHP { get; set; }
        public int ValorFlete { get; set; }
        public DateTime FechaCalculo { get; set; }
        public string DetalleDescrip { get; set; }



        //Ultima parte
        public int DuracionTrabajo { get; set; }
        public int ValorMoneda { get; set; }
        public int ValorHH { get; set; }


        public decimal HorasParejas { get; set; }
        public decimal SubtotalManoObra { get; set; }
        public decimal RecargoHHEE { get; set; }
        public decimal Total { get; set; }

        public decimal ValorVenta { get; set; }
        public decimal ValorMargenVenta { get; set; }
        public int CantidadFletes { get; set; }
        public decimal TotalFletes { get; set; }

        public int ValorManoObra { get; set; }
        public int ValorRepuestos { get; set; }
        public int ValorTerceros { get; set; }
        public int ValorFletes { get; set; }

        public decimal Subtotal { get; set; }
        public decimal TotalnetoComisiones { get; set; }

    }

    public class PresupuestoRepuestoViewModel
    {
        public int RepuestoId { get; set; }
        public string Respuesto { get; set; }
        public int Cantidad { get; set; }
        public int Codigo { get; set; }
        public int ValorUnitario { get; set; }
        public int SubTotal { get; set; }
        public int HoraParHombre { get; set; }
    }
    public class PresupuestoTrabajoTercerosViewModel
    {
     
        public int TercerosId { get; set; }
        public string Terceros { get; set; } 
        public int ValTer { get; set; }
  
    }

    public class TecnicoViewModel
    {
        public string Id { get; set; }
        public string Nombre {get;set;}
    }

    public class SupervisorViewModel
    {
        public string IdSupervisor { get; set; }
        public string NombreSupervisor { get; set; }
    }

    public class ListaGeneralViewModel
    {
        //ListaGeneral
        public int CotizacionId { get; set; }
        public string Ascensor { get; set; }
        public string NumeroPresupuesto { get; set; }
        public decimal TotalNeto { get; set; }
        public string EstadoFinalizado { get; set; }

    }
}