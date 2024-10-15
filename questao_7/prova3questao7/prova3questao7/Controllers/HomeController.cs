using Microsoft.AspNetCore.Mvc;

namespace MeuProjeto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Codi")] // Definindo o roteamento baseado em atributo para /Codi
        public IActionResult Details()
        {
            return Content("Codi Academy");
        }
    }
}
