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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Restaurante()
        {
            var menu = MenuService.Instancia.ObtenerMenu();
            return View(menu);
        }
    }
}
