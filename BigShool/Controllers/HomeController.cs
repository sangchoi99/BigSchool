using BigShool.Models;
using BigShool.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;

namespace BigShool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //BigSchoolContext context = new BigSchoolContext();
            //var upcomingCourse = context.Courses.Where(p => p.DateTime > DateTime.Now).OrderBy(p => p.DateTime).ToList();
            //foreach (Course i in upcomingCourse)
            //{
            //    ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(i.LeturerId);
            //    i.Name = user.Name;
            //}
            //return View(upcomingCourse);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}