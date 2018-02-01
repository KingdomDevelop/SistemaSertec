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
        IList<PresupuestoEntity> obtenerPresupuesto();
        int guardarPresupuesto(PresupuestoEntity entidad);

        IList<PresupuestoComercialEntity> ObtenerPresupuestoComercial();

        int guardarPresupuestoOrdenTrabajo(PresupuestoOrdenTrabajoEntity entidad);

        int guardarPresupuestoRepuesto(PresupuestoRepuestoEntity entidad);
        void guardarPresupuestoRepuestoDetalle(PresupuestoRepuestoDetalleEntity entidad);
        int guardarPresupuestoTerceros(PresupuestoTercerosEntity entidad);
        void guardarPresupuestoResumenMoDetalle(PresupuestoResumenMoDetalleEntity entidad);
        int guardarPresupuestoResumen(PresupuestoTrabajoResumenEntity entidad);
        void guardarPresupuestoControlOt(PresupuestoControlOtEntity entidad);
        void guardarPresupuestoOtRep(PresupuestoOtRepEntity entidad);
    }
}
