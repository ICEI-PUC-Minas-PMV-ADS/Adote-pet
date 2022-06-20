using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto_Adote_Pet.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;
using static Projeto_Adote_Pet.Models.PetModel;

namespace Projeto_Adote_Pet.Controllers
{
    
    
    public class PetController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public PetController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

// GET: Pet
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["EspecieSortParm"] = String.IsNullOrEmpty(sortOrder) ? "especie_desc" : "";
            ViewData["CidadeSortParm"] = sortOrder == "Cidade" ? "cidade_desc" : "Cidade";
            ViewData["CurrentFilter"] = searchString;

            var pets = from s in _context.Pets.Include(x=>x.Usuario)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {

         //Para pesquisa em enumerações apresentou erro

                pets = pets.Where(s => s.Raca.Contains(searchString)
                    || s.Cidade.Contains(searchString)
                //s => s.Especie.Contains(searchString)
                || s.Sexo==(SexoEnum)Enum.Parse(typeof(SexoEnum),searchString));

                //|| s.Porte.Contains(searchString)

                //|| s.Estado.Contains(searchString)
                //|| s.Pstatus.Contains(searchString)

            }

            switch (sortOrder)
            {
                case "especie_desc":
                    pets = pets.OrderByDescending(s => s.Especie);
                    break;
                case "Cidade":
                    pets = pets.OrderBy(s => s.Cidade);
                    break;
                case "cidade_desc":
                    pets = pets.OrderByDescending(s => s.Cidade);
                    break;
                default:
                    pets = pets.OrderBy(s => s.Especie);
                    break;
            }
            return View(await pets.AsNoTracking().ToListAsync());
        }

// GET: Pet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petModel = await _context.Pets
                .FirstOrDefaultAsync(m => m.Idanimal == id);
            if (petModel == null)
            {
                return NotFound();
            }

            return View(petModel);
        }

// GET: Pet/Create e imagens
        public IActionResult Create()
        {
            return View();
        }

// POST: Pet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]

// Inicio imagens
      
        public async Task<IActionResult> Create(PetViewModel model)
        {
            var usuario = User;
            if (ModelState.IsValid)
            {
                await _context.SaveChangesAsync();
                string nomeUnicoArquivo = UploadedFile(model);
                PetModel employee = new PetModel
        {
            Idanimal = model.Idanimal,
            Especie = (PetModel.EspecieEnum)model.Especie,
            Sexo = (PetModel.SexoEnum)model.Sexo,
            Raca = model.Raca,
            Idade = model.Idade,
            Porte = (PetModel.PorteEnum)model.Porte,
            Nome = model.Nome,
            Cor = model.Cor,
            Cidade = model.Cidade,
            Estado = (PetModel.EstadoEnum)model.Estado,
            Descricao = model.Descricao,
            Pstatus = (PetModel.PstatusEnum)model.Pstatus,
            Foto = nomeUnicoArquivo,
        };
        _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
    }
            return View();
}
        private string UploadedFile(PetViewModel model)
        {
            string nomeUnicoArquivo = null;
            if (model.Foto != null)
                {
                    string pastaFotos = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                    nomeUnicoArquivo = Guid.NewGuid().ToString() + "_" + model.Foto.FileName;
                    string caminhoArquivo = Path.Combine(pastaFotos, nomeUnicoArquivo);
                    using (var fileStream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                model.Foto.CopyTo(fileStream);
            }

        }
        return nomeUnicoArquivo;
    }

// fim da imagem

// GET: Pet/Edit/5
public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petModel = await _context.Pets.FindAsync(id);
            if (petModel == null)
            {
                return NotFound();
            }
            return View(petModel);
        }



        // POST: Pet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idanimal,Especie,Sexo,Raca,Idade,Porte,Nome,Cor,Cidade,Estado,Descricao,Pstatus,Foto")] PetModel petModel)
        {
            if (id != petModel.Idanimal)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(petModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetModelExists(petModel.Idanimal))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(petModel);
        }

        // GET: Pet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petModel = await _context.Pets
                .FirstOrDefaultAsync(m => m.Idanimal == id);
            if (petModel == null)
            {
                return NotFound();
            }

            return View(petModel);
        }

        // POST: Pet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var petModel = await _context.Pets.FindAsync(id);
            _context.Pets.Remove(petModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetModelExists(int id)
        {
            return _context.Pets.Any(e => e.Idanimal == id);
        }       
    }
}
