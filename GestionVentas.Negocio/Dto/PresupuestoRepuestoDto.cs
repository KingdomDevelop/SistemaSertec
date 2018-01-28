using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
   public class PresupuestoRepuestoDto
    {
        public int PresupuestoRepuestoId { get; set; }
        public int Presupuesto { get; set; }
        public int Repuesto { get; set; }
        public int Cantidad { get; set; }
        public int Codigo { get; set; }
        public int ValorUnitario { get; set; }
        public int SubTotal { get; set; }
        public int HoraParHombre { get; set; }
    }
}
