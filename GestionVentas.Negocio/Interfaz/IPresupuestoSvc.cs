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
        PresupuestoDto obtenerPresupuestos(int cotizacionID);

        IList<PresupuestoComercialDto> obtenerPresupuestoComercial();

        int guardarPresupuestoOrdenTrabajo(PresupuestoOrdenTrabajoDto ordenTrabajo);

        int guardarPresupuestoRepuesto(PresupuestoRepuestoDto presupuestoRepuesto);

        int guardarPresupuestoTerceros(PresupuestoTercerosDto presupuestoTercero);

        int guardarPresupuestoResumen(PresupuestoTrabajoResumenDto presupuestoResumen);

        IList<ListadoCotizacionDto> obtenerListadoCotizaciones();
        ContabilidadDto obtenerContabilidadInfo(int idCotizacion);
        int guardarContabilidadInfo(ContabilidadDto contabilidad);
        FormaPagoDto obtenerFormaPago(int idContabilidad);
        void guardarFormaPago(FormaPagoDto formaPago);
        IList<FacturacionDto> obtenerFacturacion(int idContabilidad);
        void guardarFacturacion(FacturacionDto facturacion);

        IList<PresupuestoTercerosDto> obtenerTerceros(int idCotizacion);
        IList<PresupuestoRepuestoDto> obtenerRepuestos(int idCotizacion);
    }
}
