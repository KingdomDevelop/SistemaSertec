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

        public PresupuestoEntity obtenerPresupuesto(int cotizacionID)
        {
            var lstPresupuesto = new PresupuestoEntity();

            //lstPresupuesto.Obra = "Nueva Obra";
            //lstPresupuesto.Ascensor = "Ascensor Final";
            //lstPresupuesto.Supervisor = "Gran Jefe";
            //lstPresupuesto.TecEmisor = "Terrile Pollo";
            //lstPresupuesto.PresupuestoNumero = "15964";
            //lstPresupuesto.DetalleDescrip = "Cambio de linea";
            //lstPresupuesto.DuracionTrabajo = 6;
            //lstPresupuesto.FechaCalculo = Convert.ToDateTime("06-03-2018");
            //lstPresupuesto.ValorRepuestos = 3698;
            //lstPresupuesto.ValorTerceros = 36;
            //lstPresupuesto.ValorManoObra = 100;
            //lstPresupuesto.CantidadFletes = 1;
            //lstPresupuesto.HorasParejas = 12;
            //lstPresupuesto.Subtotal = 300;
            //lstPresupuesto.TotalnetoComisiones = 169;

            using (var context = new ContextoBdSantiago())
            {
                var datos = context.Cotizacion;

                if (datos.Any())
                {
                    lstPresupuesto = datos.Where(c => c.PK_Cotizacion_ID == cotizacionID).Select(c => new PresupuestoEntity
                    {
                        Obra = c.Obra,
                        Ascensor = c.Ascensor,
                        Supervisor = c.Supervisor,
                        TecEmisor = c.TecnicoEmisor,
                        PresupuestoNumero = c.PresupuestoNumero,
                        DetalleDescrip = c.DescripcionDetalle,
                        DuracionTrabajo = (int)c.DuracionTrabajo,
                        FechaCalculo = c.FechaCalculo,
                        ValorRepuestos = (int)c.ValorRepuestos,
                        ValorTerceros = (int)c.ValorTerceros,
                        ValorManoObra = (int)c.ValorManoObra,
                        CantidadFletes = (int)c.CantidadFletes,


                        //FechaEmision = c.FechaEmision,
                        //HorasParejas = (decimal)c.HorasParejas,

                        //PresupuestoId = c.PK_Cotizacion_ID,

                        //RecargoHHEE = (decimal)c.RecargoHHEE,
                        //Subtotal = (decimal)c.SubTotal,
                        //SubtotalManoObra = (decimal)c.SubTotalManoObra,

                        //Total = (decimal)c.Total,
                        //TotalFletes = (decimal)c.TotalFletes,
                        //TotalnetoComisiones = (decimal)c.TotalNetoComisiones,
                        //ValorFlete = Convert.ToInt32(c.ValorFlete),
                        //ValorFletes = Convert.ToInt32(c.ValorFletes),
                        //ValorHH = Convert.ToInt32(c.ValorHH),
                        //ValorHP = c.ValorHP,

                        //ValorMargenVenta = (decimal)c.ValorMargenVenta,
                        //ValorMoneda = Convert.ToInt32(c.ValorMoneda),

                        //ValorUf = c.ValorUf,
                        //ValorVenta = (decimal)c.ValorVenta
                    }).FirstOrDefault();
                }
                //solo para asegurarnos que cierre la conexion
                context.Dispose();
            }

            return lstPresupuesto;
        }

        public IList<ListadoCotizacionEntity> ObtenerListadoCotizacion()
        {
            var lstCotizacion = new List<ListadoCotizacionEntity>();


            //var dato = new ListadoCotizacionEntity { Ascensor = "prueba", CotizacionId = 1, NumeroPresupuesto = "12587", EstadoFinalizado = true, TotalNeto = 100 };
            //var dato2 = new ListadoCotizacionEntity { Ascensor = "efectivo", CotizacionId = 2, NumeroPresupuesto = "9688", EstadoFinalizado = false, TotalNeto = 650 };

            //lstCotizacion.Add(dato);
            //lstCotizacion.Add(dato2);

            using (var context = new ContextoBdSantiago())
            {
                var cotizacion = context.Cotizacion;
                var contabilidad = context.Contabilidad;

                if (cotizacion.Any())
                {
                    lstCotizacion = (from cot in cotizacion
                                     join conta in contabilidad on cot.PK_Cotizacion_ID equals conta.PK_Cotizacion_ID into Relacion
                                     from rel in Relacion.DefaultIfEmpty()
                                     select new ListadoCotizacionEntity
                                     {
                                         Ascensor = cot.Ascensor,
                                         CotizacionId = cot.PK_Cotizacion_ID,
                                         NumeroPresupuesto = cot.PresupuestoNumero,
                                         TotalNeto = (decimal)cot.TotalNetoComisiones,
                                         EstadoFinalizado = (rel == null) ? false : true
                                     }).ToList();
                }

                //solo para asegurarnos que cierre la conexion
                context.Dispose();
            }
            return lstCotizacion;
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

        public void guardarFacturacion(FacturacionEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                var fact = new contabilidadfacturacion
                {
                    Mes = entidad.Mes,
                    NumeroCuota = entidad.NumeroCuota,
                    NumeroFactura = entidad.NumeroGuia,
                    Valor = entidad.ValorCuota,
                    PK_ContabilidadID = entidad.NumeroContabilidad
                };

                contexto.ContabilidadFacturacion.Add(fact);
                contexto.SaveChanges();
            }
        }

        public IList<FacturacionEntity> obtenerFacturacion(int contabilidadID)
        {
            var lstFacturacion = new List<FacturacionEntity>();

            using (var context = new ContextoBdSantiago())
            {
                var datos = context.ContabilidadFacturacion;

                if (datos.Any())
                {
                    lstFacturacion = datos.Where(x => x.PK_ContabilidadID == contabilidadID).Select(c => new FacturacionEntity
                    {
                        NumeroContabilidad = (int)c.PK_ContabilidadID,
                        Mes = (int)c.Mes,
                        NumeroCuota = (int)c.NumeroCuota,
                        NumeroGuia = (int)c.NumeroFactura,
                        ValorCuota = (decimal)c.Valor

                    }).ToList();
                }
                //solo para asegurarnos que cierre la conexion
                context.Dispose();
            }

            return lstFacturacion;
        }

        public void guardarFormaPago(FormaPagoEntity entidad)
        {
            using (var contexto = new ContextoBdSantiago())
            {
                var fact = new contabilidadformapago
                {
                    CantidadCuotas = Convert.ToInt32(entidad.NumeroCuotas),
                    Cien = entidad.PagoCien,
                    Cincuenta = entidad.PagoCincuenta,
                    Cuotas = entidad.PagoCuotas,
                    PK_ContabilidadID = entidad.NumeroContabilidad
                };

                var descuentos = new contabilidaddescuentos
                {
                    PK_ContabilidadID = entidad.NumeroContabilidad,
                    Cinco = entidad.DescuentoCinco,
                    Otro = entidad.OtroDescuentos,
                    ValorOtro = Convert.ToInt32(entidad.OtroDescuentoDescripcion),
                    Quince = entidad.DescuentoQuince
                };

                var aprobacion = new contabilidadaprobacion
                {
                    PK_ContabilidadID = entidad.NumeroContabilidad,
                    DescripcionOtro = entidad.OtraAprobacionDescripcion,
                    Otro = entidad.OtraAprobacion,
                    OrdenCompra = entidad.OrdenCompra,
                    PresupuestoFirmado = entidad.PresupuestoFirmado
                };

                contexto.ContabilidadFormaPago.Add(fact);
                contexto.ContabilidadDescuentos.Add(descuentos);
                contexto.ContabilidadAprobacion.Add(aprobacion);
                contexto.SaveChanges();
            }
        }

        public FormaPagoEntity obtenerFormaPago(int contabilidadID)
        {
            var FormaPago = new FormaPagoEntity();

            using (var context = new ContextoBdSantiago())
            {

                var contabilidad = context.Contabilidad;
                var aprobacion = context.ContabilidadAprobacion;
                var formaPago = context.ContabilidadFormaPago;
                var descuentos = context.ContabilidadDescuentos;


                if (contabilidad.Any())
                {
                    FormaPago = (from conta in contabilidad.Where(c => c.PK_Cotizacion_ID == contabilidadID)
                                 join aproba in aprobacion on conta.PK_ContabilidadID equals aproba.PK_ContabilidadID into ContaAprobacion
                                 from apro in ContaAprobacion.DefaultIfEmpty()
                                 join formaPag in formaPago on conta.PK_ContabilidadID equals formaPag.PK_ContabilidadID into ContaPago
                                 from pago in ContaPago.DefaultIfEmpty()
                                 join descuen in descuentos on conta.PK_ContabilidadID equals descuen.PK_ContabilidadID into ContaDesc
                                 from desc in ContaDesc.DefaultIfEmpty()
                                 select new FormaPagoEntity
                                 {
                                     DescuentoCinco = desc.Cinco ?? false,
                                     DescuentoQuince = desc.Quince ?? false,
                                     NumeroContabilidad = pago == null ? 0 : conta.PK_ContabilidadID,
                                     NumeroCuotas = pago.CantidadCuotas.ToString(),
                                     OrdenCompra = apro.OrdenCompra ?? false,
                                     OtraAprobacion = apro.Otro ?? false,
                                     OtraAprobacionDescripcion = apro.DescripcionOtro,
                                     OtroDescuentos = desc.Otro ?? false,
                                     OtroDescuentoDescripcion = desc.ValorOtro.ToString(),
                                     OtroPago = pago.Otro ?? false,
                                     OtroPagoDescripcion = pago.DescripcionOtro,
                                     PagoCien = pago.Cien ?? false,
                                     PagoCincuenta = pago.Cincuenta ?? false,
                                     PagoCuotas = pago.Cuotas ?? false,
                                     PresupuestoFirmado = apro.PresupuestoFirmado ?? false

                                 }).FirstOrDefault();

                }
                //solo para asegurarnos que cierre la conexion
                context.Dispose();
            }

            return FormaPago;
        }

        public int guardarContabilidad(ContabilidadEntity entidad)
        {
            int contabilidad = 0;

            using (var contexto = new ContextoBdSantiago())
            {
                var conta = new contabilidad
                {
                    ComisionOtros = entidad.ComisionOtros,
                    ComisionVendedor = entidad.ComisionVendedor,
                    PK_Cotizacion_ID = entidad.Cotizacion,
                    TelefonoContacto = entidad.TelefonoContacto,
                    Vendedor = entidad.Vendedor,
                    PersonaAprobacion = entidad.PersonaAprobacion,
                    Direccion = entidad.Direccion,
                    Factura = entidad.Factura,
                    FechaEjecucion = entidad.FechaEjecucion,
                    FechaInicio = entidad.FechaInicio,
                    FechaTermino = entidad.FechaTermino,
                    GuiaDespacho = entidad.GuiaDespacho,
                    MesFacturacion = entidad.MesFacturacion
                };

                contexto.Contabilidad.Add(conta);
                contexto.SaveChanges();

                contabilidad = conta.PK_ContabilidadID;
            }

            return contabilidad;
        }

        public ContabilidadEntity obtenerContabilidad(int cotizacionID)
        {
            var conta = new ContabilidadEntity();

            using (var context = new ContextoBdSantiago())
            {
                var datos = context.Contabilidad;

                if (datos.Any())
                {
                    conta = datos.Where(x => x.PK_Cotizacion_ID == cotizacionID).Select(c => new ContabilidadEntity
                    {
                        ComisionOtros = (int)c.ComisionOtros,
                        MesFacturacion = (int)c.MesFacturacion,
                        ComisionVendedor = (int)c.ComisionVendedor,
                        Direccion = c.Direccion,
                        Factura = (int)c.Factura,
                        FechaEjecucion = c.FechaEjecucion,
                        FechaInicio = c.FechaInicio,
                        FechaTermino = c.FechaTermino,
                        GuiaDespacho = c.GuiaDespacho,
                        PersonaAprobacion = c.PersonaAprobacion,
                        TelefonoContacto = c.TelefonoContacto,
                        Vendedor = c.Vendedor
                    }).FirstOrDefault();
                }
                //solo para asegurarnos que cierre la conexion
                context.Dispose();
            }

            return conta;
        }

    }
}

