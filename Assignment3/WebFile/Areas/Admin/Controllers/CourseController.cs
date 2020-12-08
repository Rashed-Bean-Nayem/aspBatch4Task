using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using WebFile.Areas.Admin.Data;
using WebFile.Models;

namespace WebFile.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Course()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Course(CourseData courseData)
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.AddModelCourse(courseData);
            return View();
        }

    }
}
