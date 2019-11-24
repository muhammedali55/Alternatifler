using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlternatiflerCore.Models;
using AlternatiflerCore.Models.MyModels;
using Microsoft.AspNetCore.Mvc;

namespace AlternatiflerCore.Controllers
{
    [Route("[controller]/[action]")]
    public class ApplicationController : Controller
    {
        dbalternatifContext _context;
        public ApplicationController(dbalternatifContext context)
        {
            _context = context;
        }

        public IActionResult Index(String ad)
        {
            return View();
        }

        [Route("/uygulama/{ad?}")]
        public IActionResult App(String ad)
        {
            HomeModel homeModel = new HomeModel();
            homeModel.kategorilist = _context.Tblkategoriler.ToList();
            homeModel.altkategorilist = _context.Tblsubkategori.ToList();
            homeModel.sistemlist = _context.Tblsistem.ToList();
            homeModel.altsistemlist = _context.Tblsubsistem.ToList();
            homeModel.urunlist = _context.Tblgeciciurunbilgisi.Take(10).ToList();
            homeModel.alternatiflerdearananlar = _context.Tblgeciciurunbilgisi.Where(x => x.Id > 100 && x.Id < 125).ToList();
            homeModel.encokarananlar = _context.Tblgeciciurunbilgisi.Where(x => x.Id > 1000 && x.Id < 1025).ToList();
            try
            {
                homeModel.urun = _context.Tblgeciciurunbilgisi.Where(x => x.Ad.Equals(ad)).ToList()[0];
            }
            catch (Exception ex) { 
            }
           
            
            return View(homeModel);
        }
    }
}