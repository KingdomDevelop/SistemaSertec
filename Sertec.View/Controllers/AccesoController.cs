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
        //private ApplicationSignInManager _signInManager;
        //private ApplicationUserManager _userManager;
        private readonly IUsuarioSvc _usuarioSvc;
        // GET: Acceso

        //public AccesoController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        //{
        //    UserManager = userManager;
        //    SignInManager = signInManager;

        //}
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

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            //var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: true);

            var resultado = _usuarioSvc.obtenerUsuarioLogin(model.Email, model.Password);

            if (resultado != null)
            {
                if (resultado.Login != null && resultado.Estado == false)
                {
                    ModelState.AddModelError("", "Usuario sin Acceso");
                    return View("Index");
                }

                return RedirectToAction("Home", "Dashboard", new { idUsuario = resultado.UsuarioId});
            }
            ModelState.AddModelError("", "Contraseña y/o Usuario Incorrecto");
            return View("Index");

            //switch (result)
            //{
            //    case SignInStatus.Success:
            //        var userId = SignInManager.AuthenticationManager.AuthenticationResponseGrant.Identity.GetUserId();
            //        //_transversalSvc.IngresarRegistroActividad(DateTime.Now, "Usuario ingresa al sistema", model.Email);
            //        return RedirectToLocal(returnUrl); //Resultado Exitoso, a que controlador final ira
            //    case SignInStatus.LockedOut:
            //        var userToLock = await UserManager.FindByNameAsync(model.Email);
            //        //_transversalSvc.IngresarRegistroActividad(DateTime.Now, "Se bloquea cuenta por exceso de intentos fallidos", model.Email);
            //        if (userToLock != null)
            //        {
            //            await UserManager.AccessFailedAsync(userToLock.Id);
            //        }
            //        return View("Lockout");
            //    case SignInStatus.RequiresVerification:
            //        return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
            //    case SignInStatus.Failure:
            //    default:

        }
    }
        //public ApplicationSignInManager SignInManager
        //{
        //    get
        //    {
        //        return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
        //    }
        //    private set
        //    {
        //        _signInManager = value;
        //    }
        //}
        //public ApplicationUserManager UserManager
        //{
        //    get
        //    {
        //        return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //    }
        //    private set
        //    {
        //        _userManager = value;
        //    }
        //}
        //private ActionResult RedirectToLocal(string returnUrl)
        //{

        //    if (Url.IsLocalUrl(returnUrl))
        //    {
        //        //return Redirect(returnUrl);
        //        return RedirectToAction("SeleccionPoliza", "Home", new { url = returnUrl });
        //    }
        //    //return RedirectToAction("Index", "Home");
        //    return RedirectToAction("SeleccionPoliza", "Home");
        //}
    
}