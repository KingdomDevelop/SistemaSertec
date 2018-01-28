using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
    public class PresupuestoTercerosDto
    {
        public int PresupuestoTerceroId { get; set; }
        public int Presupuesto { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
    }
}
