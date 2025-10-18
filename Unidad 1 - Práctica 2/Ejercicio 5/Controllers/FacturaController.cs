using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Ejercicio_5.Controllers
{
    public class FacturaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calcular(decimal monto, string opcion)
        {
            decimal total = 0, valorAplicado = 0;
            string tipo = "";

            if (opcion == "ITBIS")
            {
                valorAplicado = monto * 0.18m;
                total = monto + valorAplicado;
                tipo = "ITBIS (18%)";
            }
            else if (opcion == "Descuento")
            {
                valorAplicado = monto * 0.15m;
                total = monto - valorAplicado;
                tipo = "Descuento (15%)";
            }
            var moneda = new CultureInfo("es-DO");

            ViewBag.Mensaje = $"Subtotal: {monto.ToString("C", moneda)}\n" +
                $"{tipo}: {valorAplicado.ToString("C", moneda)}\n" +
                $"Total: {total.ToString("C", moneda)}";
            
            return View();
        }
    }
}
