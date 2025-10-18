using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_2.Controllers
{
    public class OperacionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calcular(double a, double b, string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "Sumar": resultado = a + b; break;
                case "Restar": resultado = a - b; break;
                case "Multiplicar": resultado = a * b; break;
                case "Dividir": resultado = b != 0 ? a / b : double.NaN; break;
                case "Potencia": resultado = Math.Pow(a, b); break;
            }

            ViewBag.Resultado = $"El resultado de {operacion} es: {resultado}";
            return View();
        }
    }
}
