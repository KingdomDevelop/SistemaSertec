using GestionVentas.Negocio.Dto;
using GestionVentas.Negocio.Implementacion;
using GestionVentas.Negocio.Interfaz;
using Sertec.View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sertec.View.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IPresupuestoSvc _presupuestoSvc;

        public DashboardController()
        {
            _presupuestoSvc = new PresupuestoSvcImpl();
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home(int idUsuario)
        {
            return View();
        }

        public ActionResult Cotizacion()
        {
            Session["repuesto"] = null;
            Session["terceros"] = null;
            Session["TotalRepRep"] = null;
            Session["ValorHP"] = null;

            var tecnicosList = new List<TecnicoViewModel>();

            tecnicosList.Add(new TecnicoViewModel { Id = "AGC", Nombre = "AGC" });
            tecnicosList.Add(new TecnicoViewModel { Id = "LLN", Nombre = "LLN" });
            tecnicosList.Add(new TecnicoViewModel { Id = "MGC", Nombre = "MGC" });
            tecnicosList.Add(new TecnicoViewModel { Id = "GLN", Nombre = "GLN" });
            tecnicosList.Add(new TecnicoViewModel { Id = "Otro", Nombre = "Otro" });

            ViewBag.Tecnicos = tecnicosList;

            var supList = new List<SupervisorViewModel>();

            supList.Add(new SupervisorViewModel { IdSupervisor = "AGC", NombreSupervisor = "AGC" });
            supList.Add(new SupervisorViewModel { IdSupervisor = "LLN", NombreSupervisor = "LLN" });
            supList.Add(new SupervisorViewModel { IdSupervisor = "MGC", NombreSupervisor = "MGC" });
            supList.Add(new SupervisorViewModel { IdSupervisor = "GLN", NombreSupervisor = "GLN" });
            supList.Add(new SupervisorViewModel { IdSupervisor = "Otro", NombreSupervisor = "Otro" });

            ViewBag.Supervisor = supList;

            return View();
        }

        public ActionResult ListaGeneral()
        {
            Session["Facturacion"] = null;
            var GeneralList = new List<ListaGeneralViewModel>();
            var OperacionList = new List<ListaOperacionViewModel>();

            OperacionList.Add(new ListaOperacionViewModel
            {
                Obra = "1",
                FechaEmision = DateTime.Now,
                Ascensor = "Ascensor ABC",
                TecEmisor = "AGC",
                Supervisor = "LLN",
                RutEmpresa = "",
                Respuesto = "Repuesto ABC 1, Repuesto ABC 2",
                Vendedor = "QWE",
                DetalleDescrip = "Detalle Descripcion 1,2 y 3",
                //TrabajosTerceros = "Trabajos Terceros Detalle",
                Guia = 123
            });

            var listado = _presupuestoSvc.obtenerListadoCotizaciones();


            GeneralList = listado.Select(cotizacion => new ListaGeneralViewModel
            {
                Ascensor = cotizacion.Ascensor,
                CotizacionId = cotizacion.CotizacionId,
                EstadoFinalizado = cotizacion.EstadoFinalizado == true ? "Finalizado" : "En Proceso",
                NumeroPresupuesto = cotizacion.NumeroPresupuesto,
                TotalNeto = cotizacion.TotalNeto
            }).ToList();

            //Datos Pruebas
            //GeneralList = new List<ListaGeneralViewModel>();

            //GeneralList.Add(new ListaGeneralViewModel { CotizacionId = 1, Ascensor = "Hotel abc", NumeroPresupuesto = "101", TotalNeto = 200000, EstadoFinalizado = "EN CURSO" });
            //GeneralList.Add(new ListaGeneralViewModel { CotizacionId = 2, Ascensor = "CUARTEL MILITAL 1", NumeroPresupuesto = "102", TotalNeto = 50000, EstadoFinalizado = "FINALIZADO" });
            //GeneralList.Add(new ListaGeneralViewModel { CotizacionId = 3, Ascensor = "Holden", NumeroPresupuesto = "103", TotalNeto = 870000, EstadoFinalizado = "NULO" });
            //GeneralList.Add(new ListaGeneralViewModel { CotizacionId = 4, Ascensor = "ASCESORIAS X", NumeroPresupuesto = "104", TotalNeto = 150000, EstadoFinalizado = "RECHAZADO" });
            //GeneralList.Add(new ListaGeneralViewModel { CotizacionId = 5, Ascensor = "Otro", NumeroPresupuesto = "105", TotalNeto = 90000, EstadoFinalizado = "" });

            ViewBag.ListGeneral = GeneralList;

            return View("ListaGeneral", OperacionList);
        }

        public ActionResult AgregarCotizacion(CotizacionViewModel model)
        {

            var idCot = _presupuestoSvc.guardarPresupuesto(new PresupuestoDto
            {
                DetalleDescrip = model.DetalleDescrip,
                FechaEmision = model.FechaEmision,
                ValorFlete = model.ValorFlete,
                ValorHH = model.ValorHH,
                ValorMoneda = model.ValorMoneda,
                Ascensor = model.Ascensor,
                CantidadFletes = model.CantidadFletes,
                DuracionTrabajo = model.DuracionTrabajo,
                FechaCalculo = model.FechaCalculo,
                HorasParejas = model.HorasParejas,
                Obra = model.Obra,
                PresupuestoNumero = model.PresupuestoNumero,
                RecargoHHEE = model.RecargoHHEE,
                Subtotal = model.Subtotal,
                SubtotalManoObra = model.SubtotalManoObra,
                Supervisor = model.Supervisor,
                TecEmisor = model.TecEmisor,
                Total = model.Total,
                TotalFletes = model.TotalFletes,
                TotalnetoComisiones = model.TotalnetoComisiones,
                ValorFletes = model.ValorFletes,
                ValorHP = Convert.ToDecimal(model.ValorHP),
                ValorManoObra = model.ValorManoObra,
                ValorMargenVenta = model.ValorMargenVenta,
                ValorRepuestos = model.ValorRepuestos,
                ValorTerceros = model.ValorTerceros,
                ValorUf = Convert.ToDecimal(model.ValorUf),
                ValorVenta = model.ValorVenta


            });

            //var pptoOt = _presupuestoSvc.guardarPresupuestoOrdenTrabajo(new PresupuestoOrdenTrabajoDto
            //{
            //    Presupuesto = idCot,
            //    Obra = model.Obra,
            //    Fecha = model.FechaCalculo,
            //    Ascensor = model.Ascensor,
            //    TecnicoEmisor = model.TecEmisor,
            //    Supervisor = model.Supervisor,
            //    Descripcion = model.DetalleDescrip,
            //    FechaAprobacion = model.FechaEmision,
            //});
            if (Session["repuesto"] != null)
            {
                IList<PresupuestoRepuestoViewModel> listRepuesto = new List<PresupuestoRepuestoViewModel>();
                listRepuesto = (List<PresupuestoRepuestoViewModel>)Session["repuesto"];


                foreach (var repuesto in listRepuesto)
                {
                    var resultado = _presupuestoSvc.guardarPresupuestoRepuesto(new PresupuestoRepuestoDto
                    {
                        Cantidad = repuesto.Cantidad,
                        Codigo = repuesto.Codigo,
                        HoraParHombre = repuesto.HoraParHombre,
                        Presupuesto = idCot,
                        Repuesto = "asdasd", // valor fijo esperando validacion
                        SubTotal = repuesto.SubTotal,
                        ValorUnitario = repuesto.ValorUnitario
                    });

                }
            }

            if (Session["terceros"] != null)
            {
                IList<PresupuestoTrabajoTercerosViewModel> listTercero = new List<PresupuestoTrabajoTercerosViewModel>();
                listTercero = (List<PresupuestoTrabajoTercerosViewModel>)Session["terceros"];


                foreach (var tercero in listTercero)
                {
                    var resultado = _presupuestoSvc.guardarPresupuestoTerceros(new PresupuestoTercerosDto
                    {
                        Presupuesto = idCot,
                        Descripcion = tercero.Terceros,
                        Valor = tercero.ValTer
                    });

                }
            }

            //var resumenId = _presupuestoSvc.guardarPresupuestoResumen(new PresupuestoTrabajoResumenDto
            //{
            //    Presupuesto = idCot

            //});


            return RedirectToAction("Cotizacion");
        }



        public PartialViewResult IngresarRepuesto_Submit(PresupuestoRepuestoViewModel model)
        {
            int idRepuesto = 0;
            #region[Se incrementa el repuesto]
            IList<PresupuestoRepuestoViewModel> listModel = new List<PresupuestoRepuestoViewModel>();

            if (Session["repuesto"] == null)
            {
                model.RepuestoId = idRepuesto + 1;
                listModel.Add(model);
                Session["repuesto"] = listModel;
            }
            else
            {
                listModel = (List<PresupuestoRepuestoViewModel>)Session["repuesto"];

                model.RepuestoId = listModel.Max(c => c.RepuestoId) + 1;

                listModel.Add(model);
                Session["repuesto"] = listModel;
            }



            #endregion
            return PartialView("PresupuestoRepuestoList");
        }
        public PartialViewResult EliminarRepuesto_Submit(int id)
        {
            #region[Se incrementa el repuesto]
            IList<PresupuestoRepuestoViewModel> listModel = new List<PresupuestoRepuestoViewModel>();

            listModel = (List<PresupuestoRepuestoViewModel>)Session["repuesto"];
            listModel.Remove(listModel.Where(c => c.RepuestoId == id).FirstOrDefault());
            if (listModel.Any())
            {
                Session["repuesto"] = listModel;
            }
            else
            {
                Session["repuesto"] = null;
            }

            #endregion
            return PartialView("PresupuestoRepuestoList");
        }


        public PartialViewResult IngresarTerceros_Submit(PresupuestoTrabajoTercerosViewModel model)
        {
            int idRepuesto = 0;
            #region[Se incrementa el trabajo terceros]
            IList<PresupuestoTrabajoTercerosViewModel> listModel = new List<PresupuestoTrabajoTercerosViewModel>();

            if (Session["terceros"] == null)
            {
                model.TercerosId = idRepuesto + 1;
                listModel.Add(model);
                Session["terceros"] = listModel;
            }
            else
            {
                listModel = (List<PresupuestoTrabajoTercerosViewModel>)Session["terceros"];

                model.TercerosId = listModel.Max(c => c.TercerosId) + 1;

                listModel.Add(model);
                Session["terceros"] = listModel;
            }
            #endregion
            return PartialView("TrabajoTerceroList");
        }

        public PartialViewResult EliminarTrabajoTerceros_Submit(int id)
        {
            #region[Se incrementa el repuesto]
            IList<PresupuestoTrabajoTercerosViewModel> listModel = new List<PresupuestoTrabajoTercerosViewModel>();

            listModel = (List<PresupuestoTrabajoTercerosViewModel>)Session["terceros"];
            listModel.Remove(listModel.Where(c => c.TercerosId == id).FirstOrDefault());
            if (listModel.Any())
            {
                Session["terceros"] = listModel;
            }
            else
            {
                Session["terceros"] = null;
            }

            #endregion
            return PartialView("TrabajoTerceroList");
        }

        public ActionResult PerfilUsuario()
        {
            return View();
        }

        public PartialViewResult Contabilidad(int id)
        {
            //ContabilidadViewModel conta = new ContabilidadViewModel() { ExisteDatos = false };
            CotizacionContabilidadViewModel coti = new CotizacionContabilidadViewModel();

            var infoCoti = _presupuestoSvc.obtenerPresupuestos(id);
            var infoConta = _presupuestoSvc.obtenerContabilidadInfo(id);

            coti.CantidadFletes = infoCoti.CantidadFletes;
            coti.ValorManoObra = infoCoti.ValorManoObra;
            coti.TecEmisor = infoCoti.TecEmisor;
            coti.ValorRepuestos = infoCoti.ValorRepuestos;
            coti.ValorTerceros = infoCoti.ValorTerceros;
            coti.DuracionTrabajo = infoCoti.DuracionTrabajo;



            return PartialView("Contabilidad", coti);
        }

        public PartialViewResult Facturacion(int id)
        {
            //Datos Pruebas
            var FacturaList = new List<FacturacionViewModel>();

            //FacturaList.Add(new FacturacionViewModel { NumeroCuotas = 1, Factura = 1, Valor = 100000, Mes = "FEBRERO" });
            //FacturaList.Add(new FacturacionViewModel { NumeroCuotas = 2, Factura = 2, Valor = 500000, Mes = "MARZO" });

            var conta = _presupuestoSvc.obtenerContabilidadInfo(id);

            if (conta.Contabilidad != 0)
            {
                var fact = _presupuestoSvc.obtenerFacturacion(conta.Contabilidad);
                if (fact.Any())
                {
                    FacturaList = fact.Select(f => new FacturacionViewModel
                    {
                        Contabilidad = f.NumeroContabilidad,
                        Factura = f.NumeroGuia,
                        Mes = f.Mes.ToString(),
                        NumeroCuotas = f.NumeroCuota,
                        Valor = Convert.ToInt32(f.ValorCuota)
                    }).ToList();

                    Session["Facturacion"] = FacturaList;
                }
                else
                {
                    FacturaList.Add(new FacturacionViewModel { Contabilidad = conta.Contabilidad, Cotizacion = -1 });
                }
            }

            return PartialView("Facturacion", FacturaList);
        }

        public PartialViewResult CondicionVenta(int id)
        {
            CondicionVentaViewModel conta = new CondicionVentaViewModel() { ExisteDatos = false, NumeroContabilidad = id };

            var condicion = _presupuestoSvc.obtenerFormaPago(id);

            #region [mapeamos los datos]
            if (condicion.NumeroContabilidad != 0)
            {
                conta.ExisteDatos = true;
                conta.DescuentoCinco = condicion.DescuentoCinco;
                conta.DescuentoQuince = condicion.DescuentoQuince;
                conta.PresupuestoFirmado = condicion.PresupuestoFirmado;
                conta.NumeroContabilidad = condicion.NumeroContabilidad;
                conta.NumeroCuotas = condicion.NumeroCuotas;
                conta.OrdenCompra = condicion.OrdenCompra;
                conta.OtraAprobacion = condicion.OtraAprobacion;
                conta.OtraAprobacionDescripcion = condicion.OtraAprobacionDescripcion;
                conta.OtroDescuentoDescripcion = condicion.OtroDescuentoDescripcion;
                conta.OtroDescuentos = condicion.OtroDescuentos;
                conta.OtroPago = condicion.OtroPago;
                conta.OtroPagoDescripcion = condicion.OtroPagoDescripcion;
                conta.PagoCien = condicion.PagoCien;
                conta.PagoCincuenta = condicion.PagoCincuenta;
                conta.PagoCuotas = condicion.PagoCuotas;
            }
            #endregion

            return PartialView("CondicionVenta", conta);
        }

        public PartialViewResult Aprobacion(int id)
        {
            ContabilidadViewModel contabilidad = new ContabilidadViewModel();

            var infoCoti = _presupuestoSvc.obtenerPresupuestos(id);
            var aprobacion = _presupuestoSvc.obtenerContabilidadInfo(id);

            contabilidad.Activado = "visible";
            contabilidad.Cotizacion = id;
            contabilidad.DetalleDescrip = infoCoti.DetalleDescrip;
            contabilidad.Obra = infoCoti.Obra;
            contabilidad.Ascensor = infoCoti.Ascensor;
            contabilidad.PresupuestoNumero = infoCoti.PresupuestoNumero;
            contabilidad.TecEmisor = infoCoti.TecEmisor;

            if (aprobacion.Direccion != null)
            {
                contabilidad.Direccion = aprobacion.Direccion;
                contabilidad.PersonaAprobacion = aprobacion.PersonaAprobacion;
                contabilidad.TelefonoContacto = aprobacion.TelefonoContacto;
                contabilidad.Activado = "none";
            }

            return PartialView("ContabilidadAprobacion", contabilidad);
        }

        public PartialViewResult IngresarCondicionVenta(CondicionVentaViewModel model)
        {
            CondicionVentaViewModel conta = new CondicionVentaViewModel();

            _presupuestoSvc.guardarFormaPago(new FormaPagoDto
            {
                DescuentoCinco = model.DescuentoCinco,
                DescuentoQuince = model.DescuentoQuince,
                NumeroContabilidad = model.NumeroContabilidad,
                NumeroCuotas = model.NumeroCuotas,
                OrdenCompra = model.OrdenCompra,
                OtraAprobacion = model.OtraAprobacion,
                OtraAprobacionDescripcion = model.OtraAprobacionDescripcion,
                OtroDescuentoDescripcion = model.OtroDescuentoDescripcion,
                OtroDescuentos = model.OtroDescuentos,
                OtroPago = model.OtroPago,
                OtroPagoDescripcion = model.OtroPagoDescripcion,
                PagoCien = model.PagoCien,
                PagoCincuenta = model.PagoCincuenta,
                PagoCuotas = model.PagoCuotas,
                PresupuestoFirmado = model.PresupuestoFirmado
            });


            var condicion = _presupuestoSvc.obtenerFormaPago(model.NumeroContabilidad);

            #region [mapeamos los datos]
            if (condicion.NumeroContabilidad != 0)
            {
                conta.ExisteDatos = true;
                conta.DescuentoCinco = condicion.DescuentoCinco;
                conta.DescuentoQuince = condicion.DescuentoQuince;
                conta.PresupuestoFirmado = condicion.PresupuestoFirmado;
                conta.NumeroContabilidad = condicion.NumeroContabilidad;
                conta.NumeroCuotas = condicion.NumeroCuotas;
                conta.OrdenCompra = condicion.OrdenCompra;
                conta.OtraAprobacion = condicion.OtraAprobacion;
                conta.OtraAprobacionDescripcion = condicion.OtraAprobacionDescripcion;
                conta.OtroDescuentoDescripcion = condicion.OtroDescuentoDescripcion;
                conta.OtroDescuentos = condicion.OtroDescuentos;
                conta.OtroPago = condicion.OtroPago;
                conta.OtroPagoDescripcion = condicion.OtroPagoDescripcion;
                conta.PagoCien = condicion.PagoCien;
                conta.PagoCincuenta = condicion.PagoCincuenta;
                conta.PagoCuotas = condicion.PagoCuotas;
            }
            #endregion

            return PartialView("CondicionVenta", conta);
        }

        public PartialViewResult IngresarAprobacion(ContabilidadViewModel model)
        {

            //Valido campos ingresados
            string vende = model.Vendedor;

            var idContable = _presupuestoSvc.guardarContabilidadInfo(new ContabilidadDto
            {
                Cotizacion = model.Cotizacion,
                Direccion = model.Direccion,
                PersonaAprobacion = model.PersonaAprobacion,
                TelefonoContacto = model.TelefonoContacto
            });

            var infoCoti = _presupuestoSvc.obtenerPresupuestos(model.Cotizacion);

            ContabilidadViewModel contabilidad = new ContabilidadViewModel()
            {
                Activado = "none",
                Obra = infoCoti.Obra,
                Direccion = model.Direccion,
                Supervisor = model.Supervisor,
                Ascensor = infoCoti.Ascensor,
                PresupuestoNumero = infoCoti.PresupuestoNumero,
                TecEmisor = infoCoti.TecEmisor
            };

            return PartialView("ContabilidadAprobacion", contabilidad);
        }
        public PartialViewResult IngresarFacturacion(FacturacionViewModel model)
        {
            //Datos Pruebas
            var FacturaList = new List<FacturacionViewModel>();

            if (model != null)
            {
                _presupuestoSvc.guardarFacturacion(new FacturacionDto
                {
                    Mes = Convert.ToInt32(model.Mes),
                    NumeroContabilidad = model.Contabilidad,
                    NumeroCuota = model.NumeroCuotas,
                    NumeroGuia = model.Factura,
                    ValorCuota = model.Valor
                });
            }

            var fact = _presupuestoSvc.obtenerFacturacion(model.Contabilidad);
            if (fact.Any())
            {
                FacturaList = fact.Select(f => new FacturacionViewModel
                {
                    Contabilidad = f.NumeroContabilidad,
                    Factura = f.NumeroGuia,
                    Mes = f.Mes.ToString(),
                    NumeroCuotas = f.NumeroCuota,
                    Valor = Convert.ToInt32(f.ValorCuota)
                }).ToList();
            }

            if (Session["Facturacion"] != null)
            {
                FacturaList = (List<FacturacionViewModel>)Session["Facturacion"];
            }
            FacturaList.Add(model);

            Session["Facturacion"] = FacturaList;

            return PartialView("Facturacion", FacturaList);
        }

        public PartialViewResult Operaciones(int id)
        {
            var OperacionList = new ListaOperacionViewModel();

            var infoCotizacion = _presupuestoSvc.obtenerPresupuestos(id);
            var conta = _presupuestoSvc.obtenerContabilidadInfo(id);
            var terceros = _presupuestoSvc.obtenerTerceros(id);
            var repuesto = _presupuestoSvc.obtenerRepuestos(id);

            #region [Presupuesto]
                OperacionList.Ascensor = infoCotizacion.Ascensor;
                OperacionList.DetalleDescrip = infoCotizacion.DetalleDescrip;
                OperacionList.FechaEmision = infoCotizacion.FechaEmision;
                OperacionList.Obra = infoCotizacion.Obra;
                OperacionList.PresupuestoNumero = infoCotizacion.PresupuestoNumero;
                OperacionList.Supervisor = infoCotizacion.Supervisor;
                OperacionList.TecEmisor = infoCotizacion.TecEmisor;
            #endregion

            #region [Contabilidad]
            if (conta.Contabilidad != 0)
            {
                OperacionList.direccion = conta.Direccion;
                OperacionList.Guia = conta.GuiaDespacho;
                OperacionList.PersonaAprobado = conta.PersonaAprobacion;
                OperacionList.Telefono = conta.TelefonoContacto;
                OperacionList.Vendedor = conta.Vendedor;

            }
            #endregion

            #region [Terceros]
            if (terceros.Any())
            {
                OperacionList.Terceros = terceros.Select(ter => new PresupuestoTrabajoTercerosViewModel
                {
                    Terceros = ter.Descripcion,
                    ValTer = Convert.ToInt32(ter.Valor),
                    TercerosId = ter.PresupuestoTerceroId
                }).ToList();
            }
            #endregion

            #region [Repuestos]
            if (repuesto.Any())
            {
                OperacionList.Repuesto = repuesto.Select(rep => new PresupuestoRepuestoViewModel
                {
                    Cantidad = rep.Cantidad,
                    Codigo = rep.Codigo,
                    HoraParHombre = rep.HoraParHombre,
                    RepuestoId = rep.PresupuestoRepuestoId,
                    Respuesto = rep.Repuesto,
                    SubTotal = rep.SubTotal,
                    ValorUnitario = rep.ValorUnitario
                }).ToList();
            }
            #endregion


            return PartialView("Operaciones", OperacionList);
        }

    }
}