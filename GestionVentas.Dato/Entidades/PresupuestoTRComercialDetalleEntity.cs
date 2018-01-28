using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades
{
    public class PresupuestoTRComercialDetalleEntity
    {
        public int PresupuestoTRComercialDetalleId { get; set; }
        public int PrespuestoTrabajoResumen { get; set; }
        public decimal ValorManoObra { get; set; }
        public decimal ValorRepuesto { get; set; }
        public decimal ValorTerceros { get; set; }
        public decimal ValorFletes { get; set; }
        public decimal SubTotal { get; set; }
        public int PorcentajeComisionVendedor { get; set; }
        public decimal ValorComisionVendedor { get; set; }
        public int PorcentajeComisionOtroVendedor { get; set; }
        public decimal ValorComisionOtroVendedor { get; set; }
    }
}
