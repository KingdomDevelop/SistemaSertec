using GestionVentas.Dato.Contexto;
using GestionVentas.Dato.Entidades;
using GestionVentas.Dato.Interfaz.IDAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.DAO
{
    public class PresupuestoDao : IPresupuestoDao
    {

        public IList<PresupuestoEntity> obtenerPresupuesto()
        {
            var lstPresupuesto = new List<PresupuestoEntity>();

            using (var context = new ContextoBdSantiago())
            {


                var datos = context.Cotizacion;

                if (datos.Any())
                {
                    lstPresupuesto = datos.Select(c => new PresupuestoEntity
                    {

                    }).ToList();
                }

                //solo para asegurarnos que cierre la conexion
                context.Dispose();
            }

            return lstPresupuesto;
        }

        public int guardarPresupuesto(PresupuestoEntity entidad)
        {
            int idResultado = 0;

            using (var contexto = new ContextoBdSantiago())
            {

                var cot = new cotizacion
                {
                    Obra = entidad.Obra,
                    DuracionTrabajo = entidad.DuracionTrabajo,
                    DescripcionDetalle = entidad.DetalleDescrip,
                    FechaCalculo = entidad.FechaCalculo,
                    FechaEmision = entidad.FechaEmision,
                    HorasParejas = entidad.HorasParejas,
                    Ascensor = entidad.Ascensor,
                    CantidadFletes = entidad.CantidadFletes,
                    PresupuestoNumero = entidad.PresupuestoNumero,
                    RecargoHHEE = entidad.RecargoHHEE,
                    SubTotal = entidad.Subtotal,
                    SubTotalManoObra = entidad.SubtotalManoObra,
                    Supervisor = entidad.Supervisor,
                    TecnicoEmisor = entidad.TecEmisor,
                    Total = entidad.Total,
                    TotalFletes = entidad.TotalFletes,
                    TotalNetoComisiones = entidad.TotalnetoComisiones,
                    ValorFlete = entidad.ValorFlete,
                    ValorFletes = entidad.ValorFletes,
                    ValorHH = entidad.ValorHH,
                    ValorHP = entidad.ValorHP,
                    ValorManoObra = entidad.ValorManoObra,
                    ValorMargenVenta = entidad.ValorMargenVenta,
                    ValorMoneda = entidad.ValorMoneda,
                    ValorRepuestos = entidad.ValorRepuestos,
                    ValorTerceros = entidad.ValorTerceros,
                    ValorUf = entidad.ValorUf,
                    ValorVenta = entidad.ValorVenta

                };

                contexto.Cotizacion.Add(cot);
                contexto.SaveChanges();

                //retornamos el id del objeto, validar que entregue el identity
                idResultado = cot.PK_Cotizacion_ID;
            }

            return idResultado;
        }

        public IList<PresupuestoComercialEntity> ObtenerPresupuestoComercial()
        {
            var lstPptoComercial = new List<PresupuestoComercialEntity>();

            using (var context = new ContextoBdSantiago())
            {
                //var datos = context.PresupuestoComercial;

                //if (datos.Any())
                //{
                //    lstPptoComercial = datos.Select(c => new PresupuestoComercialEntity
                //    {
                //        PresupuestoId = c.Presupuesto,
                //        PresupuestoComercialId = c.Presupuesto_Comercial_id,
                //        Obra = (int)c.Obra,
                //        FechaAprobacion = (DateTime)c.Fecha_Aprobacion,
                //        NumeroAscensor = (int)c.Numero_Ascensor,
                //        Descripcion = c.Descripcion,
                //        NombreAprobador = c.Nombre_Aprobador,
                //        TelefonoContacto = (int)c.Telefono_Contacto,
                //        Direccion = c.Direccion
                //    }).ToList();
                //}
            }
            return lstPptoComercial;

        }

        public int guardarPresupuestoOrdenTrabajo(PresupuestoOrdenTrabajoEntity entidad)
        {
            int idResultado = 0;

            using (var contexto = new ContextoBdSantiago())
            {
                //var ppto = new presupuesto_orden_trabajo
                //{
                //    Presupuesto = entidad.PresupuestoId,
                //    Fecha = entidad.Fecha,
                //    Obra = entidad.Obra,
                //    Fecha_Aprobacion = entidad.FechaAprobacion,
                //    Ascensor = entidad.Ascensor,
                //    Tecnico_Emisor = entidad.TecnicoEmisor,
                //    Supervisor = entidad.Supervisor,
                //    Direccion = entidad.Direccion,
                //    Aprobacion = entidad.Aprobacion,
                //    Telefono_Contacto = entidad.TelefonoContacto,
                //    Descripcion = entidad.Descripcion,
                //    Descripcion_Terceros = entidad.DescripcionTerceros
                //};

                //contexto.PresupuestoOrdenTrabajo.Add(ppto);
                //contexto.SaveChanges();

                //idResultado = ppto.PK_Presupuesto_Orden_Trabajo_id;
            }

            return idResultado;
        }

        public int guardarPresupuestoRepuesto(PresupuestoRepuestoEntity entidad)
        {
            int idResultado = 0;

            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new cotizacionrepuesto
                {
                    Cantidad = entidad.Cantidad,
                    Codigo = entidad.Codigo,
                    HoraParHombre = entidad.HoraParHombre,
                    PK_Cotizacion_ID = entidad.Presupuesto,
                    Repuesto = entidad.Repuesto.ToString(),
                    SubTotal = entidad.SubTotal,
                    ValorUnitario = entidad.ValorUnitario
                };

                contexto.CotizacionRepuesto.Add(ppto);
                contexto.SaveChanges();

                idResultado = ppto.CotizacionRepuestoID;
            }

            return idResultado;
        }

        public int guardarPresupuestoTerceros(PresupuestoTercerosEntity entidad)
        {
            int idResultado = 0;

            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new cotizaciontrabajoterceros
                {
                    Terceros = entidad.Descripcion,
                    ValorTerceros = entidad.Valor,
                    PK_Cotizacion_ID = entidad.Presupuesto
                };

                contexto.CotizacionTerceros.Add(ppto);
                contexto.SaveChanges();

                idResultado = ppto.CotizacionTercerosID;
            }

            return idResultado;
        }

        public void guardarPresupuestoRepuestoDetalle(PresupuestoRepuestoDetalleEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                //var ppto = new presupuesto_repuesto_desgloce
                //{
                //    Presupuesto_Repuesto = entidad.PresupuestoTrabajoTerceros,
                //    Valor_Comision_1 = entidad.ValorComision1,
                //    Valor_Comision_2 = entidad.ValorComision2,
                //    Valor_Mano_Obra = entidad.ValorManoObra,
                //    Valor_Repuesto = entidad.ValorTrabajoTaller
                //};

                //contexto.PresupuestoRepuestoDetalle.Add(ppto);
                //contexto.SaveChanges();

            }
        }

        public void guardarPresupuestoResumenMoDetalle(PresupuestoResumenMoDetalleEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                //var ppto = new presupuesto_trabajo_resumen_mo_detalle
                //{
                //    Horas_Parejas = entidad.HorasParejas,
                //    Recargo_HH_EE = entidad.RecargoHHEE,
                //    SubTotal = entidad.Subtotal,
                //    Total = entidad.Total,
                //    Presupuesto_Trabajo_Resumen = entidad.PresupuestoTrabajoResumen
                //};

                //contexto.PresupuestoResumenMoDetalle.Add(ppto);
                //contexto.SaveChanges();

            }
        }

        public int guardarPresupuestoComisionDetalle(PresupuestoTRComisionDetalleEntity entidad)
        {
            int idResultado = 0;

            using (var contexto = new ContextoBdSantiago())
            {
                //var ppto = new presupuesto_trabajo_resumen_comision_detalle
                //{
                //    Cantidad_Fletes = entidad.CantidadFletes,
                //    Presupuesto_Trabajo_Resumen = entidad.PresupuestoTrabajoResumen,
                //    Total_Fletes = entidad.TotalFletes,
                //    Valor_Margen_Venta = entidad.ValorMargenVenta,
                //    Valor_Venta = entidad.ValorVenta
                //};

                //contexto.PresupuestoResumenComisionDetalle.Add(ppto);
                //contexto.SaveChanges();

                //idResultado = ppto.PK_ppto_trabajo_resumen_comision_detalle_id;
            }
            return idResultado;
        }

        public void guardarPresupuestoComisionDesgloce(PresupuestoTRComisionDesgloceEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                //var ppto = new presupuesto_trabajo_resumen_comision_desgloce
                //{
                //    Total = entidad.Total,
                //    Valor_Comision_1 = entidad.ValorComision1,
                //    Valor_Comision_2 = entidad.ValorComision2,
                //    Ppto_trabajo_resumen_comision_detalle = entidad.PresupuestoTrComisionDetalle,
                //    Valor_Flete = entidad.ValorFlete,
                //    Valor_Mano_Obra = entidad.ValorManoObra
                //};

                //contexto.PresupuestoResumenComisionDesgloce.Add(ppto);
                //contexto.SaveChanges();
            }
        }

        public int guardarPresupuestoResumen(PresupuestoTrabajoResumenEntity entidad)
        {
            int idResultado = 0;

            using (var contexto = new ContextoBdSantiago())
            {
                //var ppto = new presupuesto_trabajo_resumen
                //{
                //    Presupuesto = entidad.Presupuesto,
                //    Descripcion = entidad.Descripcion,
                //    SubTotal = entidad.Subtotal,
                //    Total_Neto_Comsiones = entidad.TotalnetoComisiones
                //};

                //contexto.PresupuestoTrabajoResumen.Add(ppto);
                //contexto.SaveChanges();

                //idResultado = ppto.PK_Presupuesto_Trabajo_Resumen_id;
            }
            return idResultado;
        }

        public void guardarPresupuestoControlOt(PresupuestoControlOtEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                //var ppto = new presupuesto_control_orden_trabajo
                //{
                //    Presupuesto_Orden_Trabajo = entidad.PresupuestoOrdenTrabajo,
                //    Fecha_Termino_Supervisor = entidad.FechaTerminoSupervisor,
                //    Fecha_Termino_Tecnico = entidad.FechaTerminoTecnico,
                //    Fecha_Termino_Venta = entidad.FechaTerminoVenta,
                //    Numero_Guia = entidad.NumeroGuia,
                //    Numero_Ventas = entidad.NumeroVentas,
                //    Supervisor = entidad.Supervisor,
                //    Tecnico = entidad.Tecnico
                //};

                //contexto.PresupuestoControlOt.Add(ppto);
                //contexto.SaveChanges();
            }
        }

        public void guardarPresupuestoOtRep(PresupuestoOtRepEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                //var ppto = new cotizacionrepuesto
                //{
                //    Cantidad = entidad.Cantidad,
                //    Codigo = Convert.ToInt32(entidad.Codigo),
                //    CotizacionRepuestoID = entidad.PresupuestoOtRepId,
                //    HoraParHombre = entidad.HoraParHombre,
                //    Repuesto = entidad.Descripcion,
                //    ValorUnitario = entidad.ValorUnitario,
                //    SubTotal = entidad.SubTotal

                //};

                //contexto.CotizacionRepuesto.Add(ppto);
                //contexto.SaveChanges();

            }
        }

    }
}

