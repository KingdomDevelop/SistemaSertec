using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades
{
    public class PresupuestoRepuestoEntity
    {
        public int PresupuestoRepuestoId { get; set; }
        public int Presupuesto { get; set; }
        public string Repuesto { get; set; }
        public int Cantidad { get; set; }
        public int Codigo { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public decimal HoraParHombre { get; set; }
    }
}
