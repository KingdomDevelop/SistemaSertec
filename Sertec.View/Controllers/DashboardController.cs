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
            return View();
        }
    }
}