using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Ejercicio_4.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Validar(string usuario, string contrasena)
        {
            if (usuario == "docente" && contrasena == "P@ssw0rd")
                return View();
            else
                ViewBag.Mensaje = "Usuario incorrecto";

            return View("Index");
        }
    }
}
