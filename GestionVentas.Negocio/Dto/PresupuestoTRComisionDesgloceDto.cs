using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
   public class PresupuestoTRComisionDesgloceDto
    {
        public int PresupuestoTrComisionDesgloceDesgloceId { get; set; }
        public int PresupuestoTrComisionDetalle { get; set; }
        public decimal ValorFlete { get; set; }
        public decimal ValorManoObra { get; set; }
        public decimal ValorComision1 { get; set; }
        public decimal ValorComision2 { get; set; }
        public decimal Total { get; set; }
    }
}
