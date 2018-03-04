using GestionVentas.Dato.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Interfaz.IDAO
{
    public interface IPresupuestoDao
    {
        PresupuestoEntity obtenerPresupuesto(int cotizacionID);
        int guardarPresupuesto(PresupuestoEntity entidad);

        int guardarPresupuestoRepuesto(PresupuestoRepuestoEntity entidad);
        int guardarPresupuestoTerceros(PresupuestoTercerosEntity entidad);

        IList<ListadoCotizacionEntity> ObtenerListadoCotizacion();
    }
}
