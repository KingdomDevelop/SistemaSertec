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
        public string Descripcion { get; set; }
        public int ValorMoneda { get; set; }
        public int ValorHH { get; set; }
        public int ValorFlete { get; set; }
        public DateTime FechaEmision { get; set; }
    }
}
