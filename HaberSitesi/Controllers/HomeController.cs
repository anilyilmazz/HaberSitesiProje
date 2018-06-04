using HaberSitesi.Models;
using HaberSitesi.ViewModels;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSitesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new HaberlerIndex {
                Haber = Database.Session.Query<Haberler>().ToList()
            });
        }
      
    }
}