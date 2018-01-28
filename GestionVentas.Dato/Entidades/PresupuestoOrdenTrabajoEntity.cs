using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades
{
    [Table("presupuesto_orden_trabajo")]
    public class PresupuestoOrdenTrabajoEntity
    {
        public int PresupuestoOrdenTrabajoId { get; set; }
        public int PresupuestoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Obra { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public string Ascensor { get; set; }
        public string TecnicoEmisor { get; set; }
        public string Supervisor { get; set; }
        public string Direccion { get; set; }
        public DateTime Aprobacion { get; set; }
        public int TelefonoContacto { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionTerceros { get; set;
        }


    }
}
