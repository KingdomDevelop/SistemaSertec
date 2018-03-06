using GestionVentas.Dato;
using GestionVentas.Negocio.Dto;
using GestionVentas.Negocio.Interfaz;
using GestionVentas.Negocio.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionVentas.Dato.Interfaz.IDAO;

namespace GestionVentas.Negocio.Implementacion
{
    public class PresupuestoSvcImpl : IPresupuestoSvc
    {
        private readonly IPresupuestoDao presupuestoDao;
        public PresupuestoSvcImpl()
        {
            //agregaremos transacciones aqui
            presupuestoDao = DataAccess.PresupuestoDao();
        }

        public int guardarPresupuesto(PresupuestoDto presupuesto)
        {
            //mientras retorno directo
            return presupuestoDao.guardarPresupuesto(NegocioMapper.PresupuestoToEntity(presupuesto));
        }

        public PresupuestoDto obtenerPresupuestos(int cotizacionId)
        {
            return NegocioMapper.PresupuestoToDto(presupuestoDao.obtenerPresupuesto(cotizacionId));
        }

        public IList<PresupuestoComercialDto> obtenerPresupuestoComercial()
        {
            return NegocioMapper.PresupuestoComercialDto(null);
        }

        public int guardarPresupuestoOrdenTrabajo(PresupuestoOrdenTrabajoDto ordenTrabajo)
        {
            return 1;
        }

        public int guardarPresupuestoRepuesto(PresupuestoRepuestoDto presupuestoRepuesto)
        {
            return presupuestoDao.guardarPresupuestoRepuesto(NegocioMapper.PresupuestoRepuestoToEntity(presupuestoRepuesto));
        }

        public int guardarPresupuestoTerceros(PresupuestoTercerosDto presupuestoTercero)
        {
            return presupuestoDao.guardarPresupuestoTerceros(NegocioMapper.PresupuestoTerceroEntity(presupuestoTercero));
        }

        public void guardarPresupuestoRepuestoDetalle(PresupuestoRepuestoDetalleDto presupuestoRespuestoDetalle)
        {

        }

        public int guardarPresupuestoTrabajoComercialDetalle(PresupuestoTRComercialDetalleDto pptoTRcomercialDetalle)
        {
            //todavia no es necesarios es parte de la segunda pantalla
            return 2;
        }


        public int guardarPresupuestoTrabajoComisionDesgloce(PresupuestoTRComisionDesgloceDto pptoTRcomercialComisionDesgloce)
        {
            return 3;
        }

        public void guardarPresupuestoControlOt(PresupuestoControlOtDto pptoControlOt)
        {

        }

        public void guardarPresupuestoOtRep(PresupuestoOtRepDto pptoOtRepuesto)
        {

        }

        public void guardarPresupuestoTrabajoComisionDetalle(PresupuestoTRComisionDetalleDto ptoComsionDetalle)
        {

        }

        public int guardarPresupuestoResumen(PresupuestoTrabajoResumenDto presupuestoResumen)
        {
            return 1;

        }

        public void guardarPresupuestoResumenMoDetalle(PresupuestoResumenMoDetalleDto pptoResumenMoDetalle)
        {
        }

        public IList<ListadoCotizacionDto> obtenerListadoCotizaciones()
        {
            return NegocioMapper.ListadoCotToDto(presupuestoDao.ObtenerListadoCotizacion());
        }

        public ContabilidadDto obtenerContabilidadInfo(int idCotizacion)
        {
            return NegocioMapper.ContabilidadToDto(presupuestoDao.obtenerContabilidad(idCotizacion));

        }

        public int guardarContabilidadInfo(ContabilidadDto contabilidad)
        {
            return presupuestoDao.guardarContabilidad(NegocioMapper.ContabilidadToEntity(contabilidad));
        }

        public FormaPagoDto obtenerFormaPago(int idContabilidad)
        {
            return NegocioMapper.FormaPagoToDto(presupuestoDao.obtenerFormaPago(idContabilidad));
        }

        public void guardarFormaPago(FormaPagoDto formaPago)
        {
            presupuestoDao.guardarFormaPago(NegocioMapper.FormaPagoToEntity(formaPago));
        }

        public IList<FacturacionDto> obtenerFacturacion(int idContabilidad)
        {
            return NegocioMapper.FacturacionToDto(presupuestoDao.obtenerFacturacion(idContabilidad));
        }

        public void guardarFacturacion(FacturacionDto facturacion)
        {
            presupuestoDao.guardarFacturacion(NegocioMapper.FacturacionToEntity(facturacion));
        }
    }
}
