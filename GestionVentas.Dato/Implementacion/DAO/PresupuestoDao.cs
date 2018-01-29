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


                var datos = context.Presupuesto;

                if (datos.Any())
                {
                    lstPresupuesto = datos.Select(c => new PresupuestoEntity
                    {
                        PresupuestoId = c.PK_Presupuesto_id,
                        Descripcion = c.Presupuesto_descripcion,
                        FechaEmision = c.Fecha_Emision.ToString(),
                        ValorFlete = (byte)c.Valor_Flete,
                        ValorHH = (byte)c.Valor_HH,
                        ValorMoneda = c.Valor_moneda
                    }).ToList();
                }

                //solo para asegurarnos que cierre la conexion
                context.Dispose();
            }

            return lstPresupuesto;
        }

        public int guardarPresupuesto(PresupuestoEntity entidad)
        {
            int idResultado;

            using (var contexto = new ContextoBdSantiago())
            {
                var fecha = Convert.ToDateTime(entidad.FechaEmision);

                var ppto = new presupuesto
                {
                    Fecha_Emision = fecha,
                    Presupuesto_descripcion = entidad.Descripcion,
                    Valor_moneda = entidad.ValorMoneda,
                    Valor_HH = (sbyte)entidad.ValorHH,
                    Valor_Flete = (sbyte)entidad.ValorFlete
                };

                contexto.Presupuesto.Add(ppto);
                contexto.SaveChanges();

                //retornamos el id del objeto, validar que entregue el identity
                idResultado = ppto.PK_Presupuesto_id;
            }

            return idResultado;
        }

        public IList<PresupuestoComercialEntity> ObtenerPresupuestoComercial()
        {
            var lstPptoComercial = new List<PresupuestoComercialEntity>();

            using (var context = new ContextoBdSantiago())
            {
                var datos = context.PresupuestoComercial;

                if (datos.Any())
                {
                    lstPptoComercial = datos.Select(c => new PresupuestoComercialEntity
                    {
                        PresupuestoId = c.Presupuesto,
                        PresupuestoComercialId = c.Presupuesto_Comercial_id,
                        Obra = (int)c.Obra,
                        FechaAprobacion = Convert.ToDateTime(c.Fecha_Aprobacion),
                        NumeroAscensor = (int)c.Numero_Ascensor,
                        Descripcion = c.Descripcion,
                        NombreAprobador = c.Nombre_Aprobador,
                        TelefonoContacto = (int)c.Telefono_Contacto,
                        Direccion = c.Direccion
                    }).ToList();
                }
            }
            return lstPptoComercial;

        }

        public int guardarPresupuestoOrdenTrabajo(PresupuestoOrdenTrabajoEntity entidad)
        {
            int idResultado;

            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_orden_trabajo
                {
                    Presupuesto = entidad.PresupuestoId,
                    Fecha = entidad.Fecha,
                    Obra = entidad.Obra,
                    Fecha_Aprobacion = entidad.FechaAprobacion,
                    Ascensor = entidad.Ascensor,
                    Tecnico_Emisor = entidad.TecnicoEmisor,
                    Supervisor = entidad.Supervisor,
                    Direccion = entidad.Direccion,
                    Aprobacion = entidad.Aprobacion,
                    Telefono_Contacto = entidad.TelefonoContacto,
                    Descripcion = entidad.Descripcion,
                    Descripcion_Terceros = entidad.DescripcionTerceros
                };

                contexto.PresupuestoOrdenTrabajo.Add(ppto);
                contexto.SaveChanges();

                idResultado = ppto.PK_Presupuesto_Orden_Trabajo_id;
            }

            return idResultado;
        }

        public int guardarPresupuestoRepuesto(PresupuestoRepuestoEntity entidad)
        {
            int idResultado;

            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_repuesto
                {
                    Cantidad = entidad.Cantidad,
                    Codigo = entidad.Codigo,
                    Hora_Par_Hombre = entidad.HoraParHombre,
                    Presupuesto = entidad.Presupuesto,
                    Repuesto = entidad.Repuesto,
                    Sub_Total = entidad.SubTotal,
                    Valor_Unitario = entidad.ValorUnitario
                };

                contexto.PresupuestoRepuesto.Add(ppto);
                contexto.SaveChanges();

                idResultado = ppto.PK_ppto_repuesto_id;
            }

            return idResultado;
        }

        public int guardarPresupuestoTerceros(PresupuestoTercerosEntity entidad)
        {
            int idResultado;

            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_trabajo_terceros
                {
                    Presupuesto = entidad.Presupuesto,
                    Descripcion = entidad.Descripcion,
                    Valor = entidad.Valor
                };

                contexto.PresupuestoTerceros.Add(ppto);
                contexto.SaveChanges();

                idResultado = ppto.PK_ppto_trabajo_terceros_id;
            }

            return idResultado;
        }

        public void guardarPresupuestoRepuestoDetalle(PresupuestoRepuestoDetalleEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_repuesto_desgloce
                {
                    Presupuesto_Repuesto = entidad.PresupuestoTrabajoTerceros,
                    Valor_Comision_1 = entidad.ValorComision1,
                    Valor_Comision_2 = entidad.ValorComision2,
                    Valor_Mano_Obra = entidad.ValorManoObra,
                    Valor_Repuesto = entidad.ValorTrabajoTaller
                };

                contexto.PresupuestoRepuestoDetalle.Add(ppto);
                contexto.SaveChanges();

            }
        }

        public void guardarPresupuestoResumenMoDetalle(PresupuestoResumenMoDetalleEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_trabajo_resumen_mo_detalle
                {
                    Horas_Parejas = entidad.HorasParejas,
                    Recargo_HH_EE = entidad.RecargoHHEE,
                    SubTotal = entidad.Subtotal,
                    Total = entidad.Total,
                    Presupuesto_Trabajo_Resumen = entidad.PresupuestoTrabajoResumen
                };

                contexto.PresupuestoResumenMoDetalle.Add(ppto);
                contexto.SaveChanges();

            }
        }

        public int guardarPresupuestoComisionDetalle(PresupuestoTRComisionDetalleEntity entidad)
        {
            int idResultado;

            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_trabajo_resumen_comision_detalle
                {
                    Cantidad_Fletes = entidad.CantidadFletes,
                    Presupuesto_Trabajo_Resumen = entidad.PresupuestoTrabajoResumen,
                    Total_Fletes = entidad.TotalFletes,
                    Valor_Margen_Venta = entidad.ValorMargenVenta,
                    Valor_Venta = entidad.ValorVenta
                };

                contexto.PresupuestoResumenComisionDetalle.Add(ppto);
                contexto.SaveChanges();

                idResultado = ppto.PK_ppto_trabajo_resumen_comision_detalle_id;
            }
            return idResultado;
        }

        public void guardarPresupuestoComisionDesgloce(PresupuestoTRComisionDesgloceEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_trabajo_resumen_comision_desgloce
                {
                    Total = entidad.Total,
                    Valor_Comision_1 = entidad.ValorComision1,
                    Valor_Comision_2 = entidad.ValorComision2,
                    Ppto_trabajo_resumen_comision_detalle = entidad.PresupuestoTrComisionDetalle,
                    Valor_Flete = entidad.ValorFlete,
                    Valor_Mano_Obra = entidad.ValorManoObra
                };

                contexto.PresupuestoResumenComisionDesgloce.Add(ppto);
                contexto.SaveChanges();
            }
        }

        public int guardarPresupuestoResumen(PresupuestoTrabajoResumenEntity entidad)
        {
            int idResultado;

            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_trabajo_resumen
                {
                    Presupuesto = entidad.Presupuesto,
                    Descripcion = entidad.Descripcion,
                    SubTotal = entidad.Subtotal,
                    Total_Neto_Comsiones = entidad.TotalnetoComisiones
                };

                contexto.PresupuestoTrabajoResumen.Add(ppto);
                contexto.SaveChanges();

                idResultado = ppto.PK_Presupuesto_Trabajo_Resumen_id;
            }
            return idResultado;
        }

        public void guardarPresupuestoControlOt(PresupuestoControlOtEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                var ppto = new presupuesto_control_orden_trabajo
                {
                    Presupuesto_Orden_Trabajo = entidad.PresupuestoOrdenTrabajo,
                    Fecha_Termino_Supervisor = entidad.FechaTerminoSupervisor,
                    Fecha_Termino_Tecnico = entidad.FechaTerminoTecnico,
                    Fecha_Termino_Venta = entidad.FechaTerminoVenta,
                    Numero_Guia = entidad.NumeroGuia,
                    Numero_Ventas = entidad.NumeroVentas,
                    Supervisor = entidad.Supervisor,
                    Tecnico = entidad.Tecnico
                };

                contexto.PresupuestoControlOt.Add(ppto);
                contexto.SaveChanges();
            }
        }

    }
}

