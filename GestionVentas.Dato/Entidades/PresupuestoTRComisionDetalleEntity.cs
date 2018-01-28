using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades
{
    public class PresupuestoTRComisionDetalleEntity
    {
        public int PresupuestoTrComisionDetalleId { get; set; }
        public int PresupuestoTrabajoResumen { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorMargenVenta { get; set; }
        public int CantidadFletes { get; set; }
        public decimal TotalFletes { get; set; }
    }
}
