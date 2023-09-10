using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyehatRehber.Models.Entity;
namespace SeyehatRehber.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Gallery()
        {
            var degerler = c.Blogs.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult EnYeniler()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult EnYeniler1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Skip(2).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult PopulerYorum()
        {
            var degerler = c.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }

        
    }
}