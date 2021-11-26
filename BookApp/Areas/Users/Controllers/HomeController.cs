using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Controllers;

namespace WebApp.Areas.Users.Controllers
{[Area("Users")]
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
 
            return View(app.Employee.GetEmployee());
        }
    }
}
