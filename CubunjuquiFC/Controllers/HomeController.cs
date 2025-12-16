using System.Diagnostics;
using CubunjuquiFC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CubunjuquiFC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IA()
        {
            return View();
        }

        public IActionResult Becas()
        {
            return View();
        }
        public IActionResult BolsaEmpleo()
        {
            return View();
        }
        public IActionResult Entrenadores()
        {
            return View();
        }
        public IActionResult HistorialJugador()
        {
            return View();
        }
        public IActionResult Inventario()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Noticias()
        {
            return View();
        }
        public IActionResult Notificaciones()
        {
            return View();
        }
        public IActionResult Patrocinadores()
        {
            return View();
        }
        public IActionResult recuperaContraseña()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult roles()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
