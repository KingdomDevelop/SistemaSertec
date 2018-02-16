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
        public string DetalleDescrip { get; set; }



        //Ultima parte
        public int DuracionTrabajo { get; set; }
        public string Descripcion { get; set; }
        public int ValorMoneda { get; set; }
        public int ValorHH { get; set; }

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
     
        public string Terceros { get; set; } 
        public int ValTer { get; set; }
  
    }

    public class TecnicoViewModel
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
    }

    public class SupervisorViewModel
    {
        public int IdSupervisor { get; set; }
        public string NombreSupervisor { get; set; }
    }

    public class ListaGeneralViewModel
    {
        //ListaGeneral
        public int idLista { get; set; }
        public string NombreCliente { get; set; }
        public string RutCliente { get; set; }
        public int Nppto { get; set; }
        public int Monto { get; set; }
        public string Estado { get; set; }

        //ListaContabilidad
        public string Obra { get; set; }
        public string Ascensor { get; set; }
        public string TecEmisor { get; set; }
        public string Supervisor { get; set; }
        public string Empresa { get; set; }
        public string Rut { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public string  AprobadoPor { get; set; }
        public int NumTelefono { get; set; }
        public string Descripcion { get; set; }



    }
}