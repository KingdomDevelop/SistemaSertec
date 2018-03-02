using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
    public class PresupuestoDto
    {
        public int PresupuestoId { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Obra { get; set; }
        public string Ascensor { get; set; }
        public string TecEmisor { get; set; }
        public string Supervisor { get; set; }
        public string PresupuestoNumero { get; set; }
        public decimal ValorUf { get; set; }
        public decimal ValorHP { get; set; }
        public int ValorFlete { get; set; }
        public DateTime FechaCalculo { get; set; }
        public string DetalleDescrip { get; set; }
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
}
