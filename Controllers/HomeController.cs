using Microsoft.AspNetCore.Mvc;
using Restaurante1;
using Restaurante2.Models;
using System.Diagnostics;

namespace Restaurante2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel 
            { 
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            });
        }

        // GET
        public IActionResult Restaurante()
        {
            var menu = MenuService.Instancia.ObtenerMenu();
            return View(menu);
        }

        // POST
        [HttpPost]
        public IActionResult Restaurante(
            int Hamburguesa,
            int Cerveza,
            int Gaseosa,
            int Ensalada,
            int Salchichas,
            int Refresco,
            int Sopa,
            int Postre)
        {
            double venta =
                Hamburguesa * 5 +
                Cerveza * 3 +
                Gaseosa * 2.5 +
                Ensalada * 4 +
                Salchichas * 3.5 +
                Refresco * 2 +
                Sopa * 3 +
                Postre * 4.5;

            double impuesto = venta * 0.15;
            double total = venta + impuesto;

            ViewBag.Venta = venta.ToString("F2");
            ViewBag.Impuesto = impuesto.ToString("F2");
            ViewBag.Total = total.ToString("F2");

            var menu = MenuService.Instancia.ObtenerMenu();
            return View(menu);
        }
    }
}
