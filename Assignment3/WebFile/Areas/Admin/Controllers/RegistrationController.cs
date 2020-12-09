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
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(RegistrationData registrationData)
        {
            dynamic studentData=
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.AddModelRegistration(registrationData);
            return View();
        }
    }
}
