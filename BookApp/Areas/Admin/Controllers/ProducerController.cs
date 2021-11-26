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
    public class ProducerController : BaseController
    {       
        public IActionResult Index()
        {
            return View(app.Producer.GetProducer());
        }       
        [HttpPost]
        public IActionResult GetProducer()
        {
            return Json(app.Producer.GetProducer());
        }
        [HttpPost]       
        public IActionResult Create(Producer obj)
        {

            return Json(app.Producer.Add(obj));
            //app.Producer.Add(obj);
            //return Redirect("/Admin/Producer");
        }       
        public IActionResult Edit(string id)
        {
            return View(app.Producer.GetProducerByIdProducer(id));
        }
        [HttpPost]      
        public IActionResult Edit(Producer obj)
        {
            return Json(app.Producer.Edit(obj));
            //app.Producer.Edit(obj);
            //return Redirect("/Admin/Producer");
        }       
        public IActionResult Delete(string id)
        {
            return Json(app.Producer.Delete(id));
            //app.Producer.Delete(id);
            //return Redirect("/Admin/Producer");
        }        
    }
}