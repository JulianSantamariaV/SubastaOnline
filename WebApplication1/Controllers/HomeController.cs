using Microsoft.AspNetCore.Mvc;
using SubastaOnline.Models;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISubastaRepositorio subastaRepositorio;

        public HomeController(ILogger<HomeController> logger, ISubastaRepositorio subastaRepositorio)
        {
            _logger = logger;
            this.subastaRepositorio = subastaRepositorio;
        }

        public IActionResult Index()
        {
            var subasta = subastaRepositorio.ObtenerProyecto().ToList();
            var modelo = new HomeIndexViewModel() { Subastas = subasta };
            return View(modelo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
