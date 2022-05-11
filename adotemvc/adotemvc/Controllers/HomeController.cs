using adotemvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace adotemvc.Controllers
{
    public class HomeController : Controller
    {
//excluí linhas 14 a 19

        public IActionResult Index() //chama a página index (home)
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
                        
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
