using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto
{
    public class ContabilidadDto
    {
        public int Cotizacion { get; set; }
        public string Direccion { get; set; }
        public string PersonaAprobacion { get; set; }
        public string TelefonoContacto { get; set; }
        public string Vendedor { get; set; }
        public DateTime? FechaEjecucion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public int GuiaDespacho { get; set; }
        public int Factura { get; set; }
        public int MesFacturacion { get; set; }
        public int ComisionVendedor { get; set; }
        public int ComisionOtros { get; set; }
    }
}
