using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Foundation.Entities;

using Microsoft.AspNetCore.Mvc;
using WebFile.Areas.Admin.Data;
using WebFile.Models;

namespace WebFile.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Student(StudentData studentData) 
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.AddModelStudent(studentData);
            return View();
        }

    }
}
