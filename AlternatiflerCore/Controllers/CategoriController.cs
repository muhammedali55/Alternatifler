using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlternatiflerCore.Controllers
{
    [Route("[controller]/[action]")]
    public class CategoriController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
       
        [Route("/categori/{ad?}")]
        public String Index(String ad)
        {
            return "Kategori...: " + ad;
        }

    }
}