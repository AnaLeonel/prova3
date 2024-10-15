using prova3questao3.Models;
using prova3questao3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace prova3questao3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student()
            {
                id = "1",
                nome = "Nexus",
                turno = "Manhã",
                curso = "Fullstack"
            };

            Address address = new Address()
            {
                City = "Juiz de Fora",
                State = "MG",
                Country = "BR"
            };

            StudentDetailsViewModel viewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address
            };

            return View(viewModel);
        }
    }
}
