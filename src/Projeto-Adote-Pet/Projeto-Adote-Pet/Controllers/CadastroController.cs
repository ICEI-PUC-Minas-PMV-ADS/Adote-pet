using Projeto_Adote_Pet.Models;
using Projeto_Adote_Pet.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Projeto_Adote_Pet.Controllers
{
    public class CadastroController : Controller
    {
        //atribui a variável privada _cadastroRepositorio, por isso o _
        
        private readonly ICadastroRepositorio _cadastroRepositorio;
        public CadastroController(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;
        }
        
        public IActionResult Index()
        {
            List<CadastroModel> cadastro = _cadastroRepositorio.BuscarTodos();
            return View(cadastro);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int idanimal)
        {
            CadastroModel cadastro = _cadastroRepositorio.ListarIdanimal(idanimal);
            return View(cadastro);
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        //método HttpPost insere dados, já sem ele somente lê
        [HttpPost]
        public IActionResult Criar(CadastroModel cadastro)
        {
            _cadastroRepositorio.Adicionar(cadastro);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(CadastroModel cadastro)
        {
            _cadastroRepositorio.Atualizar(cadastro);
            return RedirectToAction("Index");
        }
    }
}
