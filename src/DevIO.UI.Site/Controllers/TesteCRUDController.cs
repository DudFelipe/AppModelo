using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCRUDController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCRUDController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Eduardo",
                DataNascimento = DateTime.Now,
                Email = "email@email.com"
            };

            _contexto.Alunos.Add(aluno); //Adicionando o aluno na memória do entity framework
            _contexto.SaveChanges(); //Salvando no banco

            var aluno2 = _contexto.Alunos.Find(aluno.Id); //Buscando por ID
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "email@email.com"); //Buscando por Email
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Eduardo"); //Buscando uma coleção de alunos

            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno); //Fazendo um Update na memória
            _contexto.SaveChanges(); //Salvando as alterações no banco

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}
