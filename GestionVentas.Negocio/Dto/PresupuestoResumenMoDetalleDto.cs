using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
    public class PresupuestoResumenMoDetalleDto
    {
        public int PresupuestoResumenMoDetalleId { get; set; }
        public int PresupuestoTrabajoResumen { get; set; }
        public decimal HorasParejas { get; set; }
        public decimal Subtotal { get; set; }
        public decimal RecargoHHEE { get; set; }
        public decimal Total { get; set; }
    }
}
