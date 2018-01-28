using GestionVentas.Dato.Contexto;
using GestionVentas.Dato.DAO;
using GestionVentas.Dato.Interfaz.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato
{
    public class DataAccess
    {
        private static readonly ContextoBdSantiago contextFactory = new ContextoBdSantiago();

        public static IPresupuestoDao PresupuestoDao()
        {
            return new PresupuestoDao();
        }

    }
}
