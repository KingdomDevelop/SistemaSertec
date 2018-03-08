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
        public string Nombre { get; set; }
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

    public class ContabilidadViewModel
    {
        public string Activado { get; set; }
        public string Ascensor { get; set; }
        public int Cotizacion { get; set; }
        public string Obra { get; set; }

        public string Direccion { get; set; }
        public string PresupuestoNumero { get; set; }
        public string DetalleDescrip { get; set; }
        public string PersonaAprobacion { get; set; }
        public string TelefonoContacto { get; set; }
        public string Vendedor { get; set; }
        public DateTime? FechaEjecucion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public string TecEmisor { get; set; }
        public string Supervisor { get; set; }
        public int GuiaDespacho { get; set; }
        public int Factura { get; set; }
        public int MesFacturacion { get; set; }
        public int ComisionVendedor { get; set; }
        public int ComisionOtros { get; set; }
    }

    public class CotizacionContabilidadViewModel
    {
        public decimal HorasParejas { get; set; }
        public int CantidadFletes { get; set; }
        public DateTime FechaCalculo { get; set; }
        public string TecEmisor { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Guia { get; set; }
        public int Factura { get; set; }
        public string MesFacturacion { get; set; }
        public int ValorManoObra { get; set; }
        public int ValorRepuestos { get; set; }
        public int ValorTerceros { get; set; }
        public int ValorFletes { get; set; }

        public decimal Subtotal { get; set; }
        public decimal TotalnetoComisiones { get; set; }
        public int DuracionTrabajo { get; set; }
    }

    public class CondicionVentaViewModel
    {
        public bool ExisteDatos { get; set; }
        public int NumeroContabilidad { get; set; }
        public bool DescuentoCinco { get; set; }
        public bool DescuentoQuince { get; set; }
        public bool OtroDescuentos { get; set; }
        public string OtroDescuentoDescripcion { get; set; }

        public bool PagoCien { get; set; }
        public bool PagoCincuenta { get; set; }
        public bool PagoCuotas { get; set; }
        public string NumeroCuotas { get; set; }
        public bool OtroPago { get; set; }
        public string OtroPagoDescripcion { get; set; }

        public bool PresupuestoFirmado { get; set; }
        public bool OrdenCompra { get; set; }
        public bool OtraAprobacion { get; set; }
        public string OtraAprobacionDescripcion { get; set; }
    }
    public class FacturacionViewModel {
        public int NumeroCuotas { get; set; }
        public int Factura { get; set; }
        public int Valor { get; set; }
        public string Mes { get; set; }
    }
    public class ListaOperacionViewModel
    {
        public string Obra { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Ascensor { get; set; }
        public string TecEmisor { get; set; }
        public string Supervisor { get; set; }
        public string RutEmpresa { get; set; }//No existe
        public string Respuesto { get; set; }
        public string Vendedor { get; set; } //No existe
        public string DetalleDescrip { get; set; }

        //Lista de Repuesto/Reparacion Ingresados

        public string TrabajosTerceros { get; set; }

        //Control Termino de Trabajos
        public int Guia { get; set; }
    }


}