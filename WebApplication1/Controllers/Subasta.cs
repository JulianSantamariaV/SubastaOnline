using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Subasta : Controller
    {
        public IActionResult SubastaAscendente()
        {
            return View();
        }

        public IActionResult SubastaDescendente()
        {
            return View();
        }

        public IActionResult SubastaCerrada()
        {
            return View();
        }
    }
}
