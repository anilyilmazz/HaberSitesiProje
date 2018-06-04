using HaberSitesi.Models;
using HaberSitesi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSitesi.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        // GET: Admin/News
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Add(NewsAdd formdata )
        {
            if (!ModelState.IsValid)
            {
                return Redirect(Url.Content("~/News/Add"));
            }

            var haber = new Haberler()
            {
                Id =Convert.ToInt32(Session["onlineId"]),
                konu = formdata.konu,
                icerik = formdata.icerik,
                resim = formdata.resim,
                kategori = formdata.kategori,
                tarih = DateTime.Now
            };

            Database.Session.Save(haber);
            return View(formdata);
        }
    }
}