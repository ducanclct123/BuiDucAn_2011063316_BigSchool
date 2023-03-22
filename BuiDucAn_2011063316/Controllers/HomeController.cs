using BuiDucAn_2011063316.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BuiDucAn_2011063316.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _DbContext;
        public HomeController()
        {
            _DbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upCommingCourse = _DbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            return View(upCommingCourse);
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