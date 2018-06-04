using HaberSitesi.ViewModels;
using HaberSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using NHibernate.Linq;

namespace HaberSitesi.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        public object Forms { get; private set; }

        // GET: Admin/AdminHome
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    
        //KULLANICI İŞLEMLERİ
          
        [HttpPost]
        public ActionResult Login(Auth formdata)
        {
            if (!ModelState.IsValid)
            {
                return Redirect(Url.Content("~/Admin/AdminHome"));
            }

            if(Database.Session.Query<Yazarlar>().Any(x => x.email == formdata.email && x.sifre == formdata.sifre))
            {
                formdata.Id = Database.Session.Query<Yazarlar>().Where(x => x.email == formdata.email).Select(x => x.Id).FirstOrDefault();
                FormsAuthentication.SetAuthCookie(formdata.email, true);
                Session.Add("onlineId", formdata.Id);
                return Redirect(Url.Content("~/Admin/AdminHome"));
            }
            return Redirect(Url.Content("~/Admin/AdminHome"));



        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterAuth formdata)
        {
           
            
            if (!ModelState.IsValid)
            {
                return Redirect(Url.Content("~/Admin/Register"));
            }

            var user = new Yazarlar()
            {
                isim = formdata.isim,
                email = formdata.email,
                sifre = formdata.sifre
            };

            Database.Session.SaveOrUpdate(user);
            return View(formdata);
        }

    }
}