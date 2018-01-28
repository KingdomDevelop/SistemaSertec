using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades
{
    [Table("PresupuestoComercial")]
    public class PresupuestoComercialEntity
    {

        public int PresupuestoComercialId { get; set; }
        public int PresupuestoId { get; set; }
        public int Obra { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public int NumeroAscensor { get; set; }
        public string Descripcion { get; set; }
        public string NombreAprobador { get; set; }
        public int TelefonoContacto { get; set; }
        public string Direccion { get; set; }

    }

}
