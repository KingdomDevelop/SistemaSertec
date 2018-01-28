using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
   public class PresupuestoRepuestoDetalleDto
    {
        public int PresupuestoRepuestoDetalleId { get; set; }
        public int PresupuestoTrabajoTerceros { get; set; }
        public decimal ValorTrabajoTaller { get; set; }
        public decimal ValorManoObra { get; set; }
        public decimal ValorComision1 { get; set; }
        public decimal ValorComision2 { get; set; }
        public decimal Total { get; set; }
    }
}
