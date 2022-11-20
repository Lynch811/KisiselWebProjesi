using KisiselWebProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();
        // ANA SAYFA
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        // İKONLAR

        public PartialViewResult iconlar()
        {
            var deger = c.İconlars.ToList();
            return PartialView(deger);


        }
        // HAKKINDA
        public PartialViewResult hakkinda()
        {
            var deger = c.Hakkindas.ToList();
            return PartialView(deger);


        }
        //YETENEKLER
        public PartialViewResult Yetenekler()
        {
            var deger = c.Yeteneklerims.ToList();
            return PartialView(deger);


        }
        //ÇALIŞMALAR
        public PartialViewResult Calisma()
        {
            var deger = c.Calismalarims.ToList();
            return PartialView(deger);


        }
        //İLETİŞİM
        public PartialViewResult Iletisim()
        {
            var deger = c.İletisims.ToList();
            return PartialView(deger);


        }

        //COPY RİGHT

        public PartialViewResult CopyRight()
        {
            var deger = c.Copyrights.ToList();
            return PartialView(deger);


        }



    }
}