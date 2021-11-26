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
    public class MeElementController : BaseController
    {       
        public IActionResult Index()
        {
            return View(app.MeElement.GetMeElement());
        }
        [HttpPost]
        public IActionResult GetMeElement()
        {
            return Json(app.MeElement.GetMeElement());
        }
        //public IActionResult Create()
        //{            
        //    return View();
        //}
        [HttpPost]       
        public IActionResult Create(MeElement obj)
        {
            app.MeElement.Add(obj);
            return Redirect("/Admin/MeElement");
        }       
        public IActionResult Edit(string id)
        {
            return View(app.MeElement.GetMeElementByIdMeElement(id));
        }
        [HttpPost]      
        public IActionResult Edit(MeElement obj)
        {
            //app.MeElement.Edit(obj);
            //return Redirect("/Admin/MeElement");
            return Json(app.MeElement.Edit(obj));
        }       
        public IActionResult Delete(string id)
        {
            return Json(app.MeElement.Delete(id));
        }        
    }
}