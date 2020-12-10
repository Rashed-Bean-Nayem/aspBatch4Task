using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using WebFile.Areas.Admin.Data;
using WebFile.Models;

namespace WebFile.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        //public IActionResult Registration()
        //{
        //    var model = Startup.AutofacContainer.Resolve<IndexModel>();
        //    dynamic data = new ExpandoObject();
        //    data.StudentView = model.GetModelStudentsList();


        //    return View(data);
        //}

      
        public IActionResult Registration()
        {
            var model = Startup.AutofacContainer.Resolve<RegistrationData>();
            model.LoadStudents();
            model.LoadCourses();

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(RegistrationData registrationData)
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            var model2 = Startup.AutofacContainer.Resolve<RegistrationData>();
            if (ModelState.IsValid)
            {
                
                   
                    model.AddModelRegistration(registrationData);
                    model2.LoadStudents();
                    model2.LoadCourses();
                    return View(model2);
               
            }

           
            return View(model2);

        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult RegisterCourse(CreateRegisterCourseViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            model.AddRegisterCourse();
        //            model.LoadStudents();
        //            model.LoadCourses();
        //            return View(model);
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex.Message, ex);
        //        }
        //    }

        //    model.LoadStudents();
        //    model.LoadCourses();

        //    return View(model);
        //}

    }
}
