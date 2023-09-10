using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyehatRehber.Models.Entity;

namespace SeyehatRehber.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult BlogListele()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        
        public ActionResult YorumListele()
        {
            var degerler = c.Yorumlars.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult BlogEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog bg)
        {
            c.Blogs.Add(bg);
            c.SaveChanges();
            return RedirectToAction("BlogListele");
        }

        public ActionResult BlogSil(int id)
        {
            var bg = c.Blogs.Find(id);
            c.Blogs.Remove(bg);
            c.SaveChanges();
            return RedirectToAction("BlogListele", "Admin");
        }

        public ActionResult BlogDetay(int id)
        {
            var degerler = c.Blogs.Find(id);
            return View(degerler);
        }

        public ActionResult BlogGuncelle(Blog bg)
        {
            var b = c.Blogs.Find(bg.ID);
            b.BASLIK = bg.BASLIK;
            b.ACIKLAMA = bg.ACIKLAMA;
            b.BLOGIMAGE = bg.BLOGIMAGE;
            b.TARIH = bg.TARIH;
            c.SaveChanges();
            return RedirectToAction("BlogListele", "Admin");
        }

        public ActionResult YorumSil(int id)
        {
            var yr = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(yr);
            c.SaveChanges();
            return View("YorumLitele", "Admin");
        }

        public ActionResult YorumDetay(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View(yr);
        }

        public ActionResult YorumGuncelle(Yorumlar yr)
        {
            var y = c.Yorumlars.Find(yr.ID);
            y.YORUM = yr.YORUM;
            c.SaveChanges();
            return RedirectToAction("YorumListele", "Admin");
        }
    }
}