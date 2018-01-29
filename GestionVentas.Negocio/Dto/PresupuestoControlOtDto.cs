using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
    public class PresupuestoControlOtDto
    {
        public int PresupuestoControlOtId { get; set; }
        public int PresupuestoOrdenTrabajo { get; set; }
        public DateTime FechaTerminoTecnico { get; set; }
        public int NumeroGuia { get; set; }
        public string Guia { get; set; }
        public DateTime FechaTerminoSupervisor { get; set; }
        public string Supervisor { get; set; }
        public string Tecnico { get; set; }
        public int NumeroVentas { get; set; }
        public DateTime FechaTerminoVenta { get; set; }
    }
}
