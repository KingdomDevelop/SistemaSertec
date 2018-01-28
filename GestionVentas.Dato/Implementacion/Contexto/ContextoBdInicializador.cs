using GestionVentas.Dato.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Implementacion.Contexto
{
   public class ContextoBdInicializador : CreateDatabaseIfNotExists<ContextoBdSantiago>
    {
        protected override void Seed(ContextoBdSantiago context)
        {
            base.Seed(context);
        }
    }
}
