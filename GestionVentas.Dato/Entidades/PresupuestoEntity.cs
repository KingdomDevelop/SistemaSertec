using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades
{
    [Table("Presupuesto")]
    public class PresupuestoEntity
    {
        public int PresupuestoId { get; set; }
        public string Descripcion { get; set; }
        public int ValorMoneda { get; set; }
        public Byte ValorHH { get; set; }
        public Byte ValorFlete { get; set; }

        public string FechaEmision { get; set; }
    }
}
