using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigShool.Controllers
{
    public class HomeController : Controller
    {
       private ApplicationDbContext_dbConText;
        public HomeController
            {
            _dbContext = new ApplicationDbConText();
            }
        public ActionResult Index()
        {
        var upcommingCourses = _dbContext.Courses
            .Include(char => c.Lecture)
            .Include(char => c.Category)
           .Where(c => c.DateTime > DateTime.Now);
        return View(upcommingCourses);
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