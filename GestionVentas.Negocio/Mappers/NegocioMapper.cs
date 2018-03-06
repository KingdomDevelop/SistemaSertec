﻿using GestionVentas.Dato.Entidades;
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
                Ascensor = presupuesto.Ascensor,
                ValorVenta = presupuesto.ValorVenta,
                ValorUf = presupuesto.ValorUf,
                ValorTerceros = presupuesto.ValorTerceros,
                ValorRepuestos = presupuesto.ValorRepuestos,
                ValorMargenVenta = presupuesto.ValorMargenVenta,
                ValorManoObra = presupuesto.ValorManoObra,
                ValorHP = presupuesto.ValorHP,
                CantidadFletes = presupuesto.CantidadFletes,
                DetalleDescrip = presupuesto.DetalleDescrip,
                DuracionTrabajo = presupuesto.DuracionTrabajo,
                FechaCalculo = presupuesto.FechaCalculo,
                FechaEmision = presupuesto.FechaEmision,
                HorasParejas = presupuesto.HorasParejas,
                Obra = presupuesto.Obra,
                PresupuestoNumero = presupuesto.PresupuestoNumero,
                RecargoHHEE = presupuesto.RecargoHHEE,
                Subtotal = presupuesto.Subtotal,
                SubtotalManoObra = presupuesto.SubtotalManoObra,
                Supervisor = presupuesto.Supervisor,
                TecEmisor = presupuesto.TecEmisor,
                Total = presupuesto.Total,
                TotalFletes = presupuesto.TotalFletes,
                TotalnetoComisiones = presupuesto.TotalnetoComisiones,
                ValorFlete = presupuesto.ValorFlete,
                ValorFletes = presupuesto.ValorFletes,
                ValorHH = presupuesto.ValorHH,
                ValorMoneda = presupuesto.ValorMoneda

            };
        }

        public static PresupuestoDto PresupuestoToDto(PresupuestoEntity entidad)
        {
            return new PresupuestoDto
            {
                DetalleDescrip = entidad.DetalleDescrip,
                ValorMoneda = entidad.ValorMoneda,
                FechaEmision = entidad.FechaEmision,
                PresupuestoId = entidad.PresupuestoId,
                ValorFlete = entidad.ValorFlete,
                ValorHH = entidad.ValorHH,
                Ascensor = entidad.Ascensor,
                CantidadFletes = entidad.CantidadFletes,
                DuracionTrabajo = entidad.DuracionTrabajo,
                FechaCalculo = (DateTime)entidad.FechaCalculo,
                HorasParejas = entidad.HorasParejas,
                Obra = entidad.Obra,
                PresupuestoNumero = entidad.PresupuestoNumero,
                RecargoHHEE = entidad.RecargoHHEE,
                Subtotal = entidad.Subtotal,
                SubtotalManoObra = entidad.SubtotalManoObra,
                Supervisor = entidad.Supervisor,
                TecEmisor = entidad.TecEmisor,
                Total = entidad.Total,
                TotalFletes = entidad.TotalFletes,
                TotalnetoComisiones = entidad.TotalnetoComisiones,
                ValorFletes = entidad.ValorFletes,
                ValorHP = entidad.ValorHP,
                ValorManoObra = entidad.ValorManoObra,
                ValorMargenVenta = entidad.ValorMargenVenta,
                ValorRepuestos = entidad.ValorRepuestos,
                ValorTerceros = entidad.ValorTerceros,
                ValorUf = entidad.ValorUf,
                ValorVenta = entidad.ValorVenta

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

        public static ListadoCotizacionDto ListadoCotToDto(ListadoCotizacionEntity entidad)
        {
            return new ListadoCotizacionDto
            {
                CotizacionId = entidad.CotizacionId,
                Ascensor = entidad.Ascensor,
                EstadoFinalizado = entidad.EstadoFinalizado,
                NumeroPresupuesto = entidad.NumeroPresupuesto,
                TotalNeto = entidad.TotalNeto
            };
        }

        public static IList<ListadoCotizacionDto> ListadoCotToDto(IList<ListadoCotizacionEntity> lstEntidad)
        {
            IList<ListadoCotizacionDto> lstCotizacion = new List<ListadoCotizacionDto>();

            if (lstEntidad != null)
            {
                lstCotizacion = lstEntidad.Select(ListadoCotToDto).ToList();
            }
            return lstCotizacion;
        }

        public static FacturacionDto FacturacionToDto(FacturacionEntity entidad)
        {
            return new FacturacionDto
            {
                Mes = entidad.Mes,
                NumeroContabilidad = entidad.NumeroContabilidad,
                NumeroCuota = entidad.NumeroCuota,
                NumeroGuia = entidad.NumeroGuia,
                ValorCuota = entidad.ValorCuota
            };
        }

        public static IList<FacturacionDto> FacturacionToDto(IList<FacturacionEntity> lstEntidad)
        {
            var lstFacturacion = lstEntidad.Select(FacturacionToDto).ToList();

            return lstFacturacion;
        }


        public static FacturacionEntity FacturacionToEntity(FacturacionDto dto)
        {
            return new FacturacionEntity
            {
                Mes = dto.Mes,
                NumeroContabilidad = dto.NumeroContabilidad,
                NumeroCuota = dto.NumeroCuota,
                NumeroGuia = dto.NumeroGuia,
                ValorCuota = dto.ValorCuota
            };
        }

        public IList<FacturacionEntity> FacturacionToEntity(IList<FacturacionDto> lstDto)
        {
            var lstFacturacion = lstDto.Select(FacturacionToEntity).ToList();

            return lstFacturacion;
        }


        public static FormaPagoDto FormaPagoToDto(FormaPagoEntity entidad)
        {
            return new FormaPagoDto
            {
                DescuentoCinco = entidad.DescuentoCinco,
                DescuentoQuince = entidad.DescuentoQuince,
                NumeroContabilidad = entidad.NumeroContabilidad,
                NumeroCuotas = entidad.NumeroCuotas,
                OrdenCompra = entidad.OrdenCompra,
                OtraAprobacion = entidad.OtraAprobacion,
                OtraAprobacionDescripcion = entidad.OtraAprobacionDescripcion,
                OtroDescuentoDescripcion = entidad.OtroDescuentoDescripcion,
                OtroDescuentos = entidad.OtroDescuentos,
                OtroPago = entidad.OtroPago,
                OtroPagoDescripcion = entidad.OtroPagoDescripcion,
                PagoCien = entidad.PagoCien,
                PagoCincuenta = entidad.PagoCincuenta,
                PagoCuotas = entidad.PagoCuotas,
                PresupuestoFirmado = entidad.PresupuestoFirmado
            };
        }

        public static FormaPagoEntity FormaPagoToEntity(FormaPagoDto dto)
        {
            return new FormaPagoEntity
            {
                PresupuestoFirmado = dto.PresupuestoFirmado,
                DescuentoCinco = dto.DescuentoCinco,
                DescuentoQuince = dto.DescuentoQuince,
                NumeroContabilidad = dto.NumeroContabilidad,
                NumeroCuotas = dto.NumeroCuotas,
                OrdenCompra = dto.OrdenCompra,
                OtraAprobacion = dto.OtraAprobacion,
                OtraAprobacionDescripcion = dto.OtraAprobacionDescripcion,
                OtroDescuentoDescripcion = dto.OtroDescuentoDescripcion,
                OtroDescuentos = dto.OtroDescuentos,
                OtroPago = dto.OtroPago,
                OtroPagoDescripcion = dto.OtroPagoDescripcion,
                PagoCien = dto.PagoCien,
                PagoCincuenta = dto.PagoCincuenta,
                PagoCuotas = dto.PagoCuotas
            };
        }

        public static ContabilidadDto ContabilidadToDto(ContabilidadEntity entidad)
        {
            return new ContabilidadDto
            {
                ComisionOtros = entidad.ComisionOtros,
                ComisionVendedor = entidad.ComisionVendedor,
                Cotizacion = entidad.Cotizacion,
                Direccion = entidad.Direccion,
                Factura = entidad.Factura,
                FechaEjecucion = entidad.FechaEjecucion,
                FechaInicio = entidad.FechaInicio,
                FechaTermino = entidad.FechaTermino,
                GuiaDespacho = entidad.GuiaDespacho,
                MesFacturacion = entidad.MesFacturacion,
                PersonaAprobacion = entidad.PersonaAprobacion,
                TelefonoContacto = entidad.TelefonoContacto,
                Vendedor = entidad.Vendedor
            };
        }

        public static ContabilidadEntity ContabilidadToEntity(ContabilidadDto dto)
        {
            return new ContabilidadEntity
            {
                ComisionOtros = dto.ComisionOtros,
                Vendedor = dto.Vendedor,
                ComisionVendedor = dto.ComisionVendedor,
                Cotizacion = dto.Cotizacion,
                Direccion = dto.Direccion,
                Factura = dto.Factura,
                FechaEjecucion = dto.FechaEjecucion,
                FechaInicio = dto.FechaInicio,
                FechaTermino = dto.FechaTermino,
                GuiaDespacho = dto.GuiaDespacho,
                MesFacturacion = dto.MesFacturacion,
                PersonaAprobacion = dto.PersonaAprobacion,
                TelefonoContacto = dto.TelefonoContacto
            };
        }
    }
}
