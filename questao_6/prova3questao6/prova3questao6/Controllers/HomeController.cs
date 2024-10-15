using Microsoft.AspNetCore.Mvc;
using prova3questao6.Models;
using System.Diagnostics;

namespace prova3questao6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Home/Details/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }

}