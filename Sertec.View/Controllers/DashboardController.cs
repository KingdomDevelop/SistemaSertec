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
            var GeneralList = new List<ListaGeneralViewModel>();
            var listado = _presupuestoSvc.obtenerListadoCotizaciones();


            GeneralList = listado.Select(cotizacion => new ListaGeneralViewModel
            {
                Ascensor = cotizacion.Ascensor,
                CotizacionId = cotizacion.CotizacionId,
                EstadoFinalizado = cotizacion.EstadoFinalizado == true ? "Finalizado" : "En Proceso",
                NumeroPresupuesto = cotizacion.NumeroPresupuesto,
                TotalNeto = cotizacion.TotalNeto
            }).ToList();

            ViewBag.ListGeneral = GeneralList;

            return View();
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
                        Repuesto = 1, // valor fijo esperando validacion
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
    }
}