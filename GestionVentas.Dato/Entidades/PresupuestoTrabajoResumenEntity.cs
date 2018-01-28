using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades
{
   public  class PresupuestoTrabajoResumenEntity
    {
        public int PresupuestoTrabajoResumenId { get; set; }
        public int Presupuesto { get; set; }
        public string Descripcion { get; set; }
        public decimal Subtotal { get; set; }
        public decimal TotalnetoComisiones { get; set; }
    }
}
