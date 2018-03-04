using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
   public class ListadoCotizacionDto
    {
        public int CotizacionId { get; set; }
        public string Ascensor { get; set; }
        public string NumeroPresupuesto { get; set; }
        public decimal TotalNeto { get; set; }
        public bool EstadoFinalizado { get; set; }
    }
}
