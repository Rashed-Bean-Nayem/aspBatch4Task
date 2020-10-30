using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Autofac;
using TestAutoFac.Models;

namespace TestAutoFac.Controllers
{
    public class CalculatorController : Controller
    {

        public IActionResult Calculate() 
        {
            var model = Startup.AutofacContainer.Resolve<CalculatorModel>();
            return View(model);
        }
    }
}
