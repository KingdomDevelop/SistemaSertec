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

        public IList<PresupuestoDto> obtenerPresupuestos()
        {
            return NegocioMapper.PresupuestoToDto(presupuestoDao.obtenerPresupuesto());
        }

        public IList<PresupuestoComercialDto> obtenerPresupuestoComercial()
        {
            return NegocioMapper.PresupuestoComercialDto(presupuestoDao.ObtenerPresupuestoComercial());
        }

        public int guardarPresupuestoOrdenTrabajo(PresupuestoOrdenTrabajoDto ordenTrabajo)
        {
            return presupuestoDao.guardarPresupuestoOrdenTrabajo(NegocioMapper.PresupuestoOrdenTrabajoEntity(ordenTrabajo));
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
            presupuestoDao.guardarPresupuestoRepuestoDetalle(NegocioMapper.PresupuestoRepuestoDetalleEntity(presupuestoRespuestoDetalle));
        }

        public int guardarPresupuestoResumen(PresupuestoTrabajoResumenDto presupuestoResumen)
        {
            return presupuestoDao.guardarPresupuestoResumen(NegocioMapper.PresupuestoTrabajoResumenEntity(presupuestoResumen));
        }

        public void guardarPresupuestoResumenMoDetalle(PresupuestoResumenMoDetalleDto pptoResumenMoDetalle)
        {
            presupuestoDao.guardarPresupuestoResumenMoDetalle(NegocioMapper.PresupuestoResumenMoDetEntity(pptoResumenMoDetalle));
        }

        public int guardarPresupuestoTrabajoComercialDetalle(PresupuestoTRComercialDetalleDto pptoTRcomercialDetalle)
        {
            //todavia no es necesarios es parte de la segunda pantalla
            return 2;
        }

        public int guardarPresupuestoTrabajoComisionDetalle(PresupuestoTRComisionDetalleDto ptoComsionDetalle)
        {
            return 4;
        }

        public int guardarPresupuestoTrabajoComisionDesgloce(PresupuestoTRComisionDesgloceDto pptoTRcomercialComisionDesgloce)
        {
            return 3;
        }


    }
}
