using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EducationController : BaseController
    {       
        public IActionResult Index()
        {
            return View(app.Education.GetEducation());
        }
        [HttpPost]
        public IActionResult GetEducation()
        {
            return Json(app.Education.GetEducation());
        }
        public IActionResult Create()
        {            
            return View();
        }
        [HttpPost]       
        public IActionResult Create(Education obj)
        {
            return Json(app.Education.Add(obj));
            //app.Education.Add(obj);
            //return Redirect("/Admin/Education");
        }       
        public IActionResult Edit(int id)
        {
            return View(app.Education.GetEducationByIdEdu(id));
        }
        [HttpPost]      
        public IActionResult Edit(Education obj)
        {
            return Json(app.Education.Edit(obj));
            //app.Education.Edit(obj);
            //return Redirect("/Admin/Education");
        }
        public IActionResult Delete(int id)
        {
            return Json(app.Education.Delete(id));
            //app.Education.Delete(id);
            //return Redirect("/Admin/Education");
        }        
    }
}