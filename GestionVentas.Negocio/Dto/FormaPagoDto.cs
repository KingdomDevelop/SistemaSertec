using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
   public class FormaPagoDto
    {
        public int NumeroContabilidad { get; set; }
        public bool DescuentoCinco { get; set; }
        public bool DescuentoQuince { get; set; }
        public bool OtroDescuentos { get; set; }
        public string OtroDescuentoDescripcion { get; set; }

        public bool PagoCien { get; set; }
        public bool PagoCincuenta { get; set; }
        public bool PagoCuotas { get; set; }
        public string NumeroCuotas { get; set; }
        public bool OtroPago { get; set; }
        public string OtroPagoDescripcion { get; set; }

        public bool PresupuestoFirmado { get; set; }
        public bool OrdenCompra { get; set; }
        public bool OtraAprobacion { get; set; }
        public string OtraAprobacionDescripcion { get; set; }
    }
}
