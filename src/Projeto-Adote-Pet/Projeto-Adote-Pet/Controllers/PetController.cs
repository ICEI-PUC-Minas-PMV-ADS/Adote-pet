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
using Microsoft.AspNetCore.Http;

namespace Projeto_Adote_Pet.Controllers
{
    
    
    public class PetController : Controller
    {

        private readonly ApplicationDbContext _context;
        private string _filePath;


        public PetController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _filePath = env.WebRootPath;
            _context = context;
        }

// GET: Pet
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["EspecieSortParm"] = String.IsNullOrEmpty(sortOrder) ? "especie_desc" : "";
            ViewData["SexoSortParm"] = sortOrder == "Sexo" ? "sexo_desc" : "Sexo";
            ViewData["CurrentFilter"] = searchString;

        // Include(x => x.Usuario) tenta relacionar os Pets aos usuários

            var pets = from s in _context.Pets
                       .Include(p => p.Usuario)
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {

                //Para pesquisa em enumerações apresentou erro

                pets = pets.Where(s => s.Raca.Contains(searchString)
                    || s.Cidade.Contains(searchString));
                    //|| s.Especie == (EspecieEnum)Enum.Parse(typeof(EspecieEnum), searchString)
                    //|| s.Porte == (PorteEnum)Enum.Parse(typeof(PorteEnum), searchString)
                    //|| s.Pstatus == (PstatusEnum)Enum.Parse(typeof(PstatusEnum), searchString)
                    //|| s.Estado == (EstadoEnum)Enum.Parse(typeof(EstadoEnum), searchString)
                    //|| s.Sexo==(SexoEnum)Enum.Parse(typeof(SexoEnum),searchString));

            }

            switch (sortOrder)
            {
                case "especie_desc":
                    pets = pets.OrderByDescending(s => s.Especie);
                    break;
                case "Sexo":
                    pets = pets.OrderBy(s => s.Sexo);
                    break;
                case "sexo_desc":
                    pets = pets.OrderByDescending(s => s.Sexo);
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
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Idanimal == id);
            if (petModel == null)
            {
                return NotFound();
            }

            return View(petModel);
        }

        // GET: Pets/Create
        public IActionResult Create()
        {
            ViewData["UsuarioCpf"] = new SelectList(_context.Usuarios, "Cpf", "Cpf");
            return View();
        }

        // POST: Pet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Idanimal,Especie,Sexo,Raca,Idade,Porte,Nome,Cor,Cidade,Estado,Descricao,Pstatus,Foto,UsuarioCpf")] PetModel petModel, IFormFile anexo)
        {
            if (ModelState.IsValid)
            {                
                if (!ValidaImagem(anexo))
                    return View(petModel);

                var nome = SalvarArquivo(anexo);
                petModel.Foto = nome;

                _context.Add(petModel);
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioCpf"] = new SelectList(_context.Usuarios, "Cpf", "Cpf", petModel.UsuarioCpf);
            return View(petModel);
        }

        

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
            ViewData["UsuarioCpf"] = new SelectList(_context.Usuarios, "Cpf", "Cpf", petModel.UsuarioCpf);
            return View(petModel);
        }



        // POST: Pet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idanimal,Especie,Sexo,Raca,Idade,Porte,Nome,Cor,Cidade,Estado,Descricao,Pstatus,Foto,UsuarioCpf")] PetModel petModel, IFormFile anexo)
        {
            if (id != petModel.Idanimal)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (!ValidaImagem(anexo))
                        return View(petModel);

                    var nome = SalvarArquivo(anexo);
                    petModel.Foto = nome;

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
            ViewData["UsuarioCpf"] = new SelectList(_context.Usuarios, "Cpf", "Cpf", petModel.UsuarioCpf);
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
                .Include(p => p.Usuario)
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
            //para apagar as imagens também    
            string filePathName = _filePath + "\\fotos\\" + petModel.Foto;

                if (System.IO.File.Exists(filePathName))
                    System.IO.File.Delete(filePathName);

            _context.Pets.Remove(petModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetModelExists(int id)
        {
            return _context.Pets.Any(e => e.Idanimal == id);
        }     
        
        //Método para análise de imagem
        public bool ValidaImagem(IFormFile anexo)
        {
            switch (anexo.ContentType)
            {
                case "image/jpg":
                    return true;
                case "image/bmp":
                    return true;
                case "image/png":
                    return true;
                case "image/jpeg":
                    return true;
                case "image/gif":
                    return true;
                case "image/webp":
                    return true;
                default:
                    return false;
                    break;
            }
        }
        public string SalvarArquivo(IFormFile anexo)
        {
            var nome = Guid.NewGuid().ToString() + anexo.FileName;

            var filePath = _filePath + "\\fotos";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            using (var stream = System.IO.File.Create(filePath + "\\" + nome))
            {
                anexo.CopyToAsync(stream);
            }
            return nome;
        }
    }
}
