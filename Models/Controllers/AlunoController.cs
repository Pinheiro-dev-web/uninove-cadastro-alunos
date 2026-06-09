using Microsoft.AspNetCore.Mvc;
using CadastroAlunos.Models;

namespace CadastroAlunos.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return View(aluno);
            }

            return View("Confirmacao", aluno);
        }
    }
}
