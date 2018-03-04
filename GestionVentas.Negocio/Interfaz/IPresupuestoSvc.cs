using GestionVentas.Negocio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Interfaz
{
    public interface IPresupuestoSvc
    {
        int guardarPresupuesto(PresupuestoDto presupuesto);
        IList<PresupuestoDto> obtenerPresupuestos();

        IList<PresupuestoComercialDto> obtenerPresupuestoComercial();

        int guardarPresupuestoOrdenTrabajo(PresupuestoOrdenTrabajoDto ordenTrabajo);

        int guardarPresupuestoRepuesto(PresupuestoRepuestoDto presupuestoRepuesto);

        int guardarPresupuestoTerceros(PresupuestoTercerosDto presupuestoTercero);

        int guardarPresupuestoResumen(PresupuestoTrabajoResumenDto presupuestoResumen);

        IList<ListadoCotizacionDto> obtenerListadoCotizaciones();
    }
}
