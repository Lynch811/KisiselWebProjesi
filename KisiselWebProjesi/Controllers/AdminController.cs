using KisiselWebProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);

        }

        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.id);
            ag.resim = x.resim;
            ag.anabaslik = x.anabaslik;
            ag.maviyazi = x.maviyazi;
            ag.maviyaziyani = x.maviyaziyani;
            ag.isim = x.isim;
            ag.aciklama = x.aciklama;
            ag.metin = x.metin;
            
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //ana sayfadaki ikonlar  kısmı 
        public ActionResult ikonlistesi()
        {
            var deger = c.İconlars.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(İconlar p)
        {
            c.İconlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonlistesi");
        }

        public ActionResult ikonGetir(int id)
        {
            var ig = c.İconlars.Find(id);
            return View("ikonGetir", ig);
        }

        public ActionResult ikonGuncelle(İconlar x)
        {
            var ig = c.İconlars.Find(x.id);
            ig.icon = x.icon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonlistesi");
        }

        public ActionResult ikonsil(int id)
        {
            var sl = c.İconlars.Find(id);
            c.İconlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonlistesi");

        }
        //hakkında kısmı 
        public ActionResult hakkindalistesi()
        {
            var deger = c.Hakkindas.ToList();
            return View(deger);
        }
        public ActionResult HakkindaGetir(int id)
        {
            var hg = c.Hakkindas.Find(id);
            return View("HakkindaGetir", hg);

        }
        public ActionResult HakkindaGuncelle(Hakkinda x)
        {
            var hg = c.Hakkindas.Find(x.id);
            hg.baslik = x.baslik;
            hg.aciklama = x.aciklama;
            hg.metin = x.metin;
            hg.resim = x.resim;
           

            c.SaveChanges();
            return RedirectToAction("hakkindalistesi");
        }

        //yetenekler kısmı 
        public ActionResult Yeteneklistesi()
        {
            var deger = c.Yeteneklerims.ToList();
            return View(deger);
        }
        public ActionResult YetenekGetir(int id)
        {
            var yg = c.Yeteneklerims.Find(id);
            return View("YetenekGetir", yg);

        }
        public ActionResult YetenekGuncelle(Yeteneklerim x)
        {
            var yg = c.Yeteneklerims.Find(x.id);
            yg.anabaslik = x.anabaslik;
            yg.aciklama = x.aciklama;
            //1. resim için
            yg.icon1 = x.icon1;
            yg.baslik1 = x.baslik1;
            yg.metin1 = x.metin1;
            //2. resim için
            yg.icon2 = x.icon2;
            yg.baslik2 = x.baslik2;
            yg.metin2 = x.metin2;
            //3. resim için
            yg.icon3 = x.icon3;
            yg.baslik3 = x.baslik3;
            yg.metin3 = x.metin3;
            //4. resim için
            yg.icon4 = x.icon4;
            yg.baslik4 = x.baslik4;
            yg.metin4 = x.metin4;
            //5. resim için
            yg.icon5 = x.icon5;
            yg.baslik5 = x.baslik5;
            yg.metin5 = x.metin5;
            //6. resim için
            yg.icon6 = x.icon6;
            yg.baslik6 = x.baslik6;
            yg.metin6 = x.metin6;


            c.SaveChanges();
            return RedirectToAction("Yeteneklistesi");
        }

        //Çalışmalarım  kısmı 

        public ActionResult Calismalistesi()
        {
            var deger = c.Calismalarims.ToList();
            return View(deger);
        }
        public ActionResult CalismaGetir(int id)
        {
            var cg = c.Calismalarims.Find(id);
            return View("CalismaGetir", cg);

        }
        public ActionResult CalismaGuncelle(Calismalarim x)
        {
            var cg = c.Calismalarims.Find(x.id);
            cg.baslik = x.baslik;
            cg.aciklama = x.aciklama;
            //resim1
            cg.resim1 = x.resim1;
            cg.resimyazi1 = x.resimyazi1;
            //resim2
            cg.resim2 = x.resim2;
            cg.resimyazi2 = x.resimyazi2;
            //resim3
            cg.resim3 = x.resim3;
            cg.resimyazi3 = x.resimyazi3;
            //resim4
            cg.resim4 = x.resim4;
            cg.resimyazi4 = x.resimyazi4;
            //resim5
            cg.resim5 = x.resim5;
            cg.resimyazi5 = x.resimyazi5;
            //resim6
            cg.resim6 = x.resim6;
            cg.resimyazi6 = x.resimyazi6;
            //resim7
            cg.resim7 = x.resim7;
            cg.resimyazi7 = x.resimyazi7;
            //resim8
            cg.resim8 = x.resim8;
            cg.resimyazi8 = x.resimyazi8;


            c.SaveChanges();
            return RedirectToAction("Calismalistesi");
        }

        //İletişim Kısmı
        public ActionResult Iletisimlistesi()
        {
            var deger = c.İletisims.ToList();
            return View(deger);
        }
        public ActionResult IletisimGetir(int id)
        {
            var ig = c.İletisims.Find(id);
            return View("IletisimGetir", ig);

        }
        public ActionResult IletisimGuncelle(İletisim x)
        {
            var ig = c.İletisims.Find(x.id);
            ig.baslik = x.baslik;
            ig.aciklama = x.aciklama;
            


            c.SaveChanges();
            return RedirectToAction("Iletisimlistesi");
        }

        //COPY RİGHT
        public ActionResult CopyRightlistesi()
        {
            var deger = c.Copyrights.ToList();
            return View(deger);
        }
        public ActionResult CopyRightGetir(int id)
        {
            var cpg = c.Copyrights.Find(id);
            return View("CopyRightGetir", cpg);

        }
        public ActionResult CopyRightGuncelle(Copyright x)
        {
            var cpg = c.Copyrights.Find(x.id);
            cpg.yazi = x.yazi;
            



            c.SaveChanges();
            return RedirectToAction("CopyRightlistesi");
        }

    }
}