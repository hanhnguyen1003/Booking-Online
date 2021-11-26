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
    public class MedicineController : BaseController
    {       
        public IActionResult Index()
        {
            return View(app.Medicine.GetMedicine());
        }
        [HttpPost]
        public IActionResult GetMedicine()
        {
            return Json(app.Medicine.GetMedicine());
        }
        public IActionResult Create()
        {
            ViewBag.melement = new SelectList(app.MeElement.GetMeElement(), "IdMeElement", "NameMeElement" + "NameProducer");
            ViewBag.producer = new SelectList(app.Producer.GetProducer(), "IdProducer", "NameProducer");
            ViewBag.megroup = new SelectList(app.Megroup.GetMeGroup(), "IdMeGroup", "MeGroupName");
            return View();
        }
        [HttpPost]       
        public IActionResult Create(Medicine obj)
        {
            return Json(app.Medicine.Add(obj));
            //app.Medicine.Add(obj);
            //return Redirect("/Admin/Medicine");
        }       
        public IActionResult Edit(string id)
        {
            ViewBag.melement = new SelectList(app.MeElement.GetMeElement(), "IdMeElement", "NameMeElement");
            ViewBag.producer = new SelectList(app.Producer.GetProducer(), "IdProducer", "NameProducer");
            ViewBag.megroup = new SelectList(app.Megroup.GetMeGroup(), "IdMeGroup", "MeGroupName");
            return View(app.Medicine.GetMedicineByIdMedicine(id));
        }
        [HttpPost]      
        public IActionResult Edit(Medicine obj)
        {
            return Json(app.Medicine.Edit(obj));
            //app.Medicine.Edit(obj);
            //return Redirect("/Admin/Medicine");
        }       
        public IActionResult Delete(string id)
        {
            return Json(app.Medicine.Delete(id));
            //app.Medicine.Delete(id);
            //return Redirect("/Admin/Medicine");
        }        
    }
}