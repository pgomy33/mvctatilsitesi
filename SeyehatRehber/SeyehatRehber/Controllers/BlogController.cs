using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyehatRehber.Models.Entity;

namespace SeyehatRehber.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.ID).ToList();
            return View(degerler);
        }

        public ActionResult BlogDetay(int id)
        {
            //var degerler = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.BLOGID == id).ToList();
            by.Deger3 = c.Blogs.Where(x => x.ID == id).ToList();
            return View(by);
        }

        public PartialViewResult YanMenu()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.ID).Take(4).ToList();
            return PartialView(degerler);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yr)
        {
            yr.TARIH = DateTime.Now;
            c.Yorumlars.Add(yr);
            c.SaveChanges();
            return PartialView(); 
        }
    }
}