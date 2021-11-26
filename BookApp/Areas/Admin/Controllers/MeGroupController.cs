using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using WebApp.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MeGroupController : BaseController
    {       
        public IActionResult Index()
        {
            return View(app.Megroup.GetMeGroup());
        }
        [HttpPost]
        public IActionResult GetMeGroup()
        {
            return Json(app.Megroup.GetMeGroup());
        }
        [HttpPost]       
        public IActionResult Create(MeGroup obj)
        {
            return Json(app.Megroup.Add(obj));
            //app.Megroup.Add(obj);
            //return Redirect("/Admin/MeGroup");
        }       
        public IActionResult Edit(string id)
        {
            return View(app.Megroup.GetMeGroupByIdMeGroup(id));
        }
        [HttpPost]      
        public IActionResult Edit(MeGroup obj)
        {
            return Json(app.Megroup.Edit(obj));
            //app.Megroup.Edit(obj);
            //return Redirect("/Admin/MeGroup");
        }       
        public IActionResult Delete(string id)
        {
            return Json(app.Megroup.Delete(id));
            //app.Megroup.Delete(id);
            //return Redirect("/Admin/MeGroup");
        }        
    }
}