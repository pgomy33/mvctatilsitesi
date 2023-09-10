using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyehatRehber.Models.Entity;

namespace SeyehatRehber.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        Context c = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(iletisim p)
        {
            c.iletisims.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}