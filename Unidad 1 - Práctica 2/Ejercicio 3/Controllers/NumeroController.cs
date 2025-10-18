using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_3.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Verificar(int numero)
        {
            bool esFibonacci = EsFibonacci(numero);
            ViewBag.Mensaje = esFibonacci ? $"El {numero} pertenece a la serie de Fibonacci." :
                                            $"El {numero} no pertenece a la serie de Fibonacci.";
            return View();
        }

        private bool EsFibonacci(int n)
        {
            int a = 0, b = 1;
            while (b < n)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b == n || n == 0;
        }
    }
}
