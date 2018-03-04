using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades
{
  public  class FacturacionEntity
    {
        public int NumeroCuota { get; set; }
        public int NumeroGuia { get; set; }
        public decimal ValorCuota { get; set; }
        public int Mes { get; set; }
        public int NumeroContabilidad { get; set; }
    }
}
