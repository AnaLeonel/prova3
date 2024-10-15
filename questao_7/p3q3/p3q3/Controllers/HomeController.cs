using Microsoft.AspNetCore.Mvc;
using p3q3.Models;

namespace p3q3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            var aluno = new Student
            {
                Id = "1",
                Nome = "Nexus",
                Turno = "Manhã",
                Curso = "Fullstack"
            };

            ViewBag.Student = aluno;

            return View();
        }
    }
}
