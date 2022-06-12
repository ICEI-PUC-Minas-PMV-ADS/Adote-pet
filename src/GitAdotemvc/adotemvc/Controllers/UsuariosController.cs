using Microsoft.AspNetCore.Mvc;

namespace adotemvc.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
