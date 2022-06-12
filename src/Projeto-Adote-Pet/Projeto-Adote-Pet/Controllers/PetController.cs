using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Adote_Pet.Models;

namespace Projeto_Adote_Pet.Controllers
{
    public class PetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pet
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pets.ToListAsync());
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

        // GET: Pet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idanimal,Especie,Sexo,Raca,Idade,Porte,Nome,Cor,Cidade,Estado,Descricao,Pstatus,Id")] PetModel petModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(petModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
            return View(petModel);
        }

        // POST: Pet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idanimal,Especie,Sexo,Raca,Idade,Porte,Nome,Cor,Cidade,Estado,Descricao,Pstatus,Id")] PetModel petModel)
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
        //Inicio Imagem Pet

        public byte[] Imagem { get; set; }

        public class Conversor
        {
            public static byte[] ImagemParaByte(Image imagem)
            {
                using (var stream = new MemoryStream())
                {
                    imagem.Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }

            public static Image ByteParaImagem(byte[] bytes)
            {
                using (var stream = new MemoryStream(bytes))
                {
                    return Image.FromStream(stream);
                }
            }
        }
        // fim imagem
    }
}
