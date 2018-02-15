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
            return View();
        }
        [HttpPost]
        public PartialViewResult IngresarRepuesto_Submit(PresupuestoRepuestoViewModel model)
        {
            #region[Se incrementa el repuesto]
            IList<PresupuestoRepuestoViewModel> listModel = new List<PresupuestoRepuestoViewModel>();

            if (Session["repuesto"] == null)
            {
                listModel.Add(model);
                Session["repuesto"] = listModel;
            }
            else
            {
                listModel = (List<PresupuestoRepuestoViewModel>)Session["repuesto"];
                listModel.Add(model);
                Session["repuesto"] = listModel;
            }
            #endregion
            return PartialView("PresupuestoRepuestoList");
        }

   
    }
}