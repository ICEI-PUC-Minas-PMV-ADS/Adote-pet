using Microsoft.AspNetCore.Mvc;

namespace Projeto_Adote_Pet.Controllers
{
    public class CarrosselController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
