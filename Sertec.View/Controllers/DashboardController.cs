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

            tecnicosList.Add(new TecnicoViewModel { Id = 1, Nombre = "AGC" });
            tecnicosList.Add(new TecnicoViewModel { Id = 2, Nombre = "LLN" });
            tecnicosList.Add(new TecnicoViewModel { Id = 2, Nombre = "MGC" });
            tecnicosList.Add(new TecnicoViewModel { Id = 2, Nombre = "GLN" });
            tecnicosList.Add(new TecnicoViewModel { Id = 2, Nombre = "Otro" });

            ViewBag.Tecnicos = tecnicosList;

            var supList = new List<SupervisorViewModel>();

            supList.Add(new SupervisorViewModel { IdSupervisor = 1, NombreSupervisor = "AGC" });
            supList.Add(new SupervisorViewModel { IdSupervisor = 2, NombreSupervisor = "LLN" });
            supList.Add(new SupervisorViewModel { IdSupervisor = 2, NombreSupervisor = "MGC" });
            supList.Add(new SupervisorViewModel { IdSupervisor = 2, NombreSupervisor = "GLN" });
            supList.Add(new SupervisorViewModel { IdSupervisor = 2, NombreSupervisor = "Otro" });

            ViewBag.Supervisor = supList;

            return View();
        }

        public ActionResult ListaGeneral()
        {
            var GeneralList = new List<ListaGeneralViewModel>();

            GeneralList.Add(new ListaGeneralViewModel { idLista = 1, RutCliente = "11111111-1", NombreCliente = "Hotel abc" , Nppto =101, Monto =200000, Estado = "EN CURSO" });
            GeneralList.Add(new ListaGeneralViewModel { idLista = 2, RutCliente = "55555555-5", NombreCliente = "CUARTEL MILITAL 1", Nppto = 102, Monto= 50000,Estado = "FINALIZADO" });
            GeneralList.Add(new ListaGeneralViewModel { idLista = 3, RutCliente = "33333333-3", NombreCliente = "Holden", Nppto =103, Monto = 870000,Estado = "NULO" });
            GeneralList.Add(new ListaGeneralViewModel { idLista = 4, RutCliente = "99999999-9", NombreCliente = "ASCESORIAS X", Nppto =104, Monto =150000,Estado = "RECHAZADO" });
            GeneralList.Add(new ListaGeneralViewModel { idLista = 5, RutCliente = "1-K", NombreCliente = "Otro", Nppto =105, Monto =90000,Estado = ""});

            ViewBag.ListGeneral = GeneralList;

            return View();
        }

        public ActionResult AgregarCotizacion(CotizacionViewModel model)
        {

            var idCot = _presupuestoSvc.guardarPresupuesto(new PresupuestoDto
            {
                Descripcion = model.DetalleDescrip,
                FechaEmision = model.FechaEmision,
                ValorFlete = 1, //Valor mientras, se debe referenciar
                ValorHH = 1, //Valor mientras, se debe referenciar
                ValorMoneda = 1 //Valor mientras, se debe referenciar
            });

            var pptoOt = _presupuestoSvc.guardarPresupuestoOrdenTrabajo(new PresupuestoOrdenTrabajoDto
            {
                Presupuesto = idCot,
                Obra = model.Obra,
                Fecha = model.FechaCalculo,
                Ascensor = model.Ascensor,
                TecnicoEmisor = model.TecEmisor,
                Supervisor = model.Supervisor,
                Descripcion = model.DetalleDescrip,
                FechaAprobacion = model.FechaEmision,
            });
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
                listTercero = (List<PresupuestoTrabajoTercerosViewModel>)Session["repuesto"];


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

            var resumenId = _presupuestoSvc.guardarPresupuestoResumen(new PresupuestoTrabajoResumenDto
            {
                Presupuesto = idCot

            });


            return View("");
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
    }
}