using GestionVentas.Dato.Entidades;
using GestionVentas.Dato.Entidades.Usuario;
using GestionVentas.Negocio.Dto;
using GestionVentas.Negocio.Dto.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Mappers
{
    public class NegocioMapper
    {
        public static PresupuestoEntity PresupuestoToEntity(PresupuestoDto presupuesto)
        {
            return new PresupuestoEntity
            {
                Descripcion = presupuesto.Descripcion,
                FechaEmision = presupuesto.FechaEmision.ToString(),
                //el id no se guarda a entidad por ser identity
                PresupuestoId = presupuesto.PresupuestoId,
                ValorFlete = (byte)presupuesto.ValorFlete,
                ValorHH = (byte)presupuesto.ValorHH,
                ValorMoneda = presupuesto.ValorMoneda
            };
        }

        public static PresupuestoDto PresupuestoToDto(PresupuestoEntity entidad)
        {
            return new PresupuestoDto
            {
                Descripcion = entidad.Descripcion,
                ValorMoneda = entidad.ValorMoneda,
                FechaEmision = Convert.ToDateTime(entidad.FechaEmision),
                PresupuestoId = entidad.PresupuestoId,
                ValorFlete = entidad.ValorFlete,
                ValorHH = entidad.ValorHH
            };
        }

        public static IList<PresupuestoDto> PresupuestoToDto(IList<PresupuestoEntity> lstPpto)
        {
            var presupuestos = lstPpto.Select(PresupuestoToDto).ToList();

            return presupuestos;
        }

        public static PresupuestoComercialDto PresupuestoComvercialDto(PresupuestoComercialEntity entidad)
        {
            return new PresupuestoComercialDto
            {
                PresupuestoId = entidad.PresupuestoId,
                PresupuestoComercialId = entidad.PresupuestoComercialId,
                Obra = entidad.Obra,
                Descripcion = entidad.Descripcion,
                FechaAprobacion = entidad.FechaAprobacion,
                NumeroAscensor = entidad.NumeroAscensor,
                NombreAprobador = entidad.NombreAprobador,
                TelefonoContacto = entidad.TelefonoContacto,
                Direccion = entidad.Direccion
            };
        }

        public static IList<PresupuestoComercialDto> PresupuestoComercialDto(IList<PresupuestoComercialEntity> lstEntidad)
        {
            var lstComercial = lstEntidad.Select(PresupuestoComvercialDto).ToList();

            return lstComercial;
        }

        public static PresupuestoOrdenTrabajoEntity PresupuestoOrdenTrabajoEntity(PresupuestoOrdenTrabajoDto dto)
        {
            return new Dato.Entidades.PresupuestoOrdenTrabajoEntity
            {

                PresupuestoId = dto.Presupuesto,
                Fecha = dto.Fecha,
                Obra = dto.Obra,
                FechaAprobacion = dto.FechaAprobacion,
                Ascensor = dto.Ascensor,
                TecnicoEmisor = dto.TecnicoEmisor,
                Supervisor = dto.Supervisor,
                Direccion = dto.Direccion,
                Aprobacion = dto.Aprobacion,
                TelefonoContacto = dto.TelefonoContacto,
                Descripcion = dto.Descripcion,
                DescripcionTerceros = dto.DescripcionTerceros

            };
        }

        public static PresupuestoRepuestoEntity PresupuestoRepuestoToEntity(PresupuestoRepuestoDto dto)
        {
            return new PresupuestoRepuestoEntity
            {
                Cantidad = dto.Cantidad,
                Codigo = dto.Codigo,
                HoraParHombre = dto.HoraParHombre,
                Presupuesto = dto.Presupuesto,
                Repuesto = dto.Repuesto,
                SubTotal = dto.SubTotal,
                ValorUnitario = dto.ValorUnitario
            };
        }

        public static PresupuestoTercerosEntity PresupuestoTerceroEntity(PresupuestoTercerosDto dto)
        {
            return new PresupuestoTercerosEntity
            {
                Descripcion = dto.Descripcion,
                Presupuesto = dto.Presupuesto,
                Valor = dto.Valor
            };
        }

        public static PresupuestoRepuestoDetalleEntity PresupuestoRepuestoDetalleEntity(PresupuestoRepuestoDetalleDto dto)
        {
            return new PresupuestoRepuestoDetalleEntity
            {
                PresupuestoTrabajoTerceros = dto.PresupuestoTrabajoTerceros,
                Total = dto.Total,
                ValorComision1 = dto.ValorComision1,
                ValorComision2 = dto.ValorComision2,
                ValorManoObra = dto.ValorManoObra,
                ValorTrabajoTaller = dto.ValorTrabajoTaller
            };
        }

        public static PresupuestoResumenMoDetalleEntity PresupuestoResumenMoDetEntity(PresupuestoResumenMoDetalleDto dto)
        {
            return new PresupuestoResumenMoDetalleEntity
            {
                HorasParejas = dto.HorasParejas,
                PresupuestoTrabajoResumen = dto.PresupuestoTrabajoResumen,
                RecargoHHEE = dto.RecargoHHEE,
                Subtotal = dto.Subtotal,
                Total = dto.Total
            };
        }

        public static PresupuestoTRComercialDetalleEntity PresupuestoTrComercialDetalleEntity(PresupuestoTRComercialDetalleDto dto)
        {
            return new PresupuestoTRComercialDetalleEntity
            {
                PorcentajeComisionOtroVendedor = dto.PorcentajeComisionOtroVendedor,
                PorcentajeComisionVendedor = dto.PorcentajeComisionVendedor,
                PrespuestoTrabajoResumen = dto.PrespuestoTrabajoResumen,
                SubTotal = dto.SubTotal,
                ValorComisionOtroVendedor = dto.ValorComisionOtroVendedor,
                ValorComisionVendedor = dto.ValorComisionVendedor,
                ValorFletes = dto.ValorFletes,
                ValorManoObra = dto.ValorManoObra,
                ValorRepuesto = dto.ValorRepuesto,
                ValorTerceros = dto.ValorTerceros
            };
        }

        public static PresupuestoTRComisionDetalleEntity PresupuestoTrComisionDetalleEntity(PresupuestoTRComisionDetalleDto dto)
        {
            return new PresupuestoTRComisionDetalleEntity
            {
                CantidadFletes = dto.CantidadFletes,
                PresupuestoTrabajoResumen = dto.PresupuestoTrabajoResumen,
                TotalFletes = dto.TotalFletes,
                ValorMargenVenta = dto.ValorMargenVenta,
                ValorVenta = dto.ValorVenta
            };
        }


        public static PresupuestoTRComisionDesgloceEntity PresupuestoTrComisionDesgloceEntity(PresupuestoTRComisionDesgloceDto dto)
        {
            return new PresupuestoTRComisionDesgloceEntity
            {
                PresupuestoTrComisionDetalle = dto.PresupuestoTrComisionDetalle,
                Total = dto.Total,
                ValorComision1 = dto.ValorComision1,
                ValorComision2 = dto.ValorComision2,
                ValorFlete = dto.ValorFlete,
                ValorManoObra = dto.ValorManoObra
            };
        }

        public static PresupuestoTrabajoResumenEntity PresupuestoTrabajoResumenEntity(PresupuestoTrabajoResumenDto dto)
        {
            return new PresupuestoTrabajoResumenEntity
            {
                Presupuesto = dto.Presupuesto,
                Descripcion = dto.Descripcion,
                Subtotal = dto.Subtotal,
                TotalnetoComisiones = dto.TotalnetoComisiones
            };
        }
        public static PresupuestoControlOtEntity PresupuestoControlOtEntity(PresupuestoControlOtDto dto)
        {
            return new PresupuestoControlOtEntity
            {
                FechaTerminoSupervisor = dto.FechaTerminoSupervisor,
                FechaTerminoTecnico = dto.FechaTerminoTecnico,
                FechaTerminoVenta = dto.FechaTerminoVenta,
                Guia = dto.Guia,
                NumeroGuia = dto.NumeroGuia,
                NumeroVentas = dto.NumeroVentas,
                PresupuestoOrdenTrabajo = dto.PresupuestoOrdenTrabajo,
                Supervisor = dto.Supervisor,
                Tecnico = dto.Tecnico
            };
        }

        public static PresupuestoOtRepEntity PresupuestoOtRepuestoEntity(PresupuestoOtRepDto dto)
        {
            return new PresupuestoOtRepEntity
            {
                PresupuestoOrdenTrabajo = dto.PresupuestoOrdenTrabajo,
                Cantidad = dto.Cantidad,
                Codigo = dto.Codigo,
                Descripcion = dto.Descripcion
            };
        }

        public static UsuarioDto UsuarioToDto(UsuarioEntity entidad)
        {
            return new UsuarioDto
            {
                Email = entidad.Email,
                Estado = entidad.Estado,
                Login = entidad.Login,
                Password = entidad.Password,
                PersonaId = entidad.PersonaId,
                UsuarioId = entidad.UsuarioId
            };
        }
    }
}
