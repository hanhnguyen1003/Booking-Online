using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Controllers;
using WebApp.Areas.Users.Models;

namespace WebApp.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize(Roles ="Admin")]
    public class RoleController : BaseController
    {
        public IActionResult Index()
        {
            return View(app.Role.GetRoles());
        }
        [HttpPost]
        public IActionResult GetRoles()
        {
            return Json(app.Role.GetRoles());
        }
        [HttpPost]
        public IActionResult Create(Role obj)
        {
            
            return Json(app.Role.Add(obj));
        }
        public IActionResult Edit(int id)
        {
            return View(app.Role.GetRoleById(id));
        }
        [HttpPost]
        public IActionResult Edit(Role obj)
        {
            
            return Json(app.Role.Edit(obj));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Json(app.Role.Delete(id));
        }
        
        [HttpGet]
        public IActionResult EmployeeInRole(string id)
        {          
            return View(app.Role.GetEmployeeAndRoleById(id));
        }
        [HttpPost]
        public IActionResult AddEmployeeInRole(int roleId,string idEmp)
        {
            return Json(app.Role.AddEmployeeInRole(roleId, idEmp));
        }
    }
}
