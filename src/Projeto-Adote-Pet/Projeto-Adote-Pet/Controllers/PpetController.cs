using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Projeto_Adote_Pet.Models.Ppets;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Indexes.Models;
using Ppet.Models;
using Ppet.ViewModels;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Adote_Pet.Models;

namespace Ppet.Controllers
{
    public class PpetController : Controller
    {
        public ActionResult Pesquisa()
        {
            using (var db = new EstudoEntities())
            {
                var _Pet = db.Pet.ToList();
                var data = new Ppets();
                return View(data);
            }
        }
        [HttpPost]
        public ActionResult Pesquisa(Ppets _Ppet)
        {
            using (var db = new EstudoEntities())
            {
                var petPesquisa = from Pets in db.Pets
                                  where ((_Ppet.Especie == null) || (Pets.Especie == _Ppet.Especie.Trim())) && ((_Ppet.Cidade == null) || (Pets.Cidade == _Ppet.Cidade.Trim())) && ((_Ppet.Estado == null) || (Pets.Estado == _Ppet.Estado.Trim()))
                                  select new
                                  {
                                      Id = Pets.Id,
                                      Nome = Pets.Nome,
                                      Cidade = Pets.Cidade,
                                      Estado = Pets.Estado
                                  };
                List<Ppet> listaPets = new List<Ppet>();
                foreach (var reg in petPesquisa)
                {
                    Ppet petvalor = new Ppet();
                    petvalor.Id = reg.Id;
                    petvalor.Nome = reg.Nome;
                    petvalor.Cidade = reg.Cidade;
                    petvalor.Estado = reg.Estado;
                    listaPets.Add(petvalor);
                }
                _Ppet.Pets = listaPets;
                return View(_Ppet);
            }
        }
    }
}