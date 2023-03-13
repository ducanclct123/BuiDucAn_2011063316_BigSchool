using BuiDucAn_2011063316.Models;
using BuiDucAn_2011063316.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuiDucAn_2011063316.Controllers
{

    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _DbContext;
        public CoursesController() { 
            _DbContext = new ApplicationDbContext();
        }

        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _DbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}