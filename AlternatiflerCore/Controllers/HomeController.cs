using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlternatiflerCore.Models;
using AlternatiflerCore.Models.MyModels;
using Microsoft.AspNetCore.Mvc;

namespace AlternatiflerCore.Controllers
{
   
    public class HomeController : Controller
    {
        dbalternatifContext _context;
        public HomeController(dbalternatifContext context) {
            _context = context;
        }
        [Route("~/"),Route("~/index")]
        public IActionResult Index()
        {
            HomeModel homeModel = new HomeModel();
            homeModel.kategorilist = _context.Tblkategoriler.ToList();
            homeModel.altkategorilist = _context.Tblsubkategori.ToList();
            homeModel.sistemlist = _context.Tblsistem.ToList();
            homeModel.altsistemlist = _context.Tblsubsistem.ToList();
            homeModel.urunlist = _context.Tblgeciciurunbilgisi.Take(10).ToList();
            homeModel.alternatiflerdearananlar = _context.Tblgeciciurunbilgisi.Where(x => x.Id > 100 && x.Id < 125).ToList();
            homeModel.encokarananlar = _context.Tblgeciciurunbilgisi.Where(x => x.Id > 1000 && x.Id < 1025).ToList();
            return View(homeModel);
        }

        public String Welcome() {
            return "Hoş Geldiniz...";
        }
    }
}