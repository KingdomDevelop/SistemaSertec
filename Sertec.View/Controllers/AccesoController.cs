using GestionVentas.Negocio.Implementacion;
using GestionVentas.Negocio.Interfaz;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Sertec.View.Models;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sertec.View.Controllers
{
    public class AccesoController : Controller
    {
        private readonly IUsuarioSvc _usuarioSvc;

        public AccesoController()
        {
            _usuarioSvc = new UsuarioSvcImpl();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //var resultado = _usuarioSvc.obtenerUsuarioLogin(model.Email, model.Password);

            //if (resultado != null)
            //{
            //    if (resultado.Login != null && resultado.Estado == false)
            //    {
            //        ModelState.AddModelError("", "Usuario sin Acceso");
            //        return View("Index");
            //    }

            //    return RedirectToAction("Home", "Dashboard", new { idUsuario = resultado.UsuarioId });
            //}

            if (model.Email == "prueba@prueba.com")
            {
                if (model.Password != "123")
                {
                    ModelState.AddModelError("", "Usuario sin Acceso");
                    return View("Index");
                }
                return RedirectToAction("Cotizacion", "Dashboard");
            }


            ModelState.AddModelError("", "Contraseña y/o Usuario Incorrecto");
            return View("Index");

        }
    }
}
