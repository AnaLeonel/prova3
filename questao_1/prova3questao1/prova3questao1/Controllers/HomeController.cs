using Microsoft.AspNetCore.Mvc;
using prova3questao1.Models;
using System.Diagnostics;
using System.Collections.Generic;

namespace prova3questao1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Criando uma lista de objetos Student
            List<Student> students = new List<Student>
        {
            new Student { id = "1", nome = "Elso", turno = "M", curso = "Engenharia Ambiental" },
            new Student { id = "2", nome = "Lisa", turno = "T", curso = "Ciência da Computação" },
            new Student { id = "3", nome = "Ozzy", turno = "N", curso = "Artes Cênicas" }
        };

            // Passando a lista de alunos para a exibição usando ViewData
            ViewData["StudentList"] = students;

            return View();
        }

        public IActionResult AlunoDetails()
        {
            ViewData["Title"] = "Aluno da Codi";
            ViewData["Nome"] = "Nexus";
            ViewData["Turno"] = "Manhã";
            ViewData["Curso"] = "Fullstack";

            return View();
        }

    }
}