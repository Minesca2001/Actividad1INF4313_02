using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_1.Controllers
{
    public class InscripcionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Usuario(string nombre, DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear) edad--;

            ViewBag.Mensaje = $"Hola, {nombre}. Tienes {edad} años y tu año de nacimiento es {fechaNacimiento.Year}.";
            return View();
        }
    }
}
