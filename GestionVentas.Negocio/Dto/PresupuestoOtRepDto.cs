using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
    public class PresupuestoOtRepDto
    {
        public int PresupuestoOtRepId { get; set; }
        public int PresupuestoOrdenTrabajo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Codigo { get; set; }
    }
}
