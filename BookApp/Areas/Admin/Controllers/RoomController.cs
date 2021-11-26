using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RoomController : BaseController
    {       
        public IActionResult Index()
        {
            return View(app.Room.GetRoom());
        }
        [HttpPost]
        public IActionResult GetRoom()
        {
            return Json(app.Room.GetRoom());
        }
        public IActionResult Create()
        {
            ViewBag.department = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View();
        }
        [HttpPost]       
        public IActionResult Create(Room obj)
        {
            return Json(app.Room.Add(obj));
        }       
        public IActionResult Edit(int id)
        {
            ViewBag.department = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View(app.Room.GetRoomByOrdinalRoom(id));
        }
        [HttpPost]      
        public IActionResult Edit(Room obj)
        {
            return Json(app.Room.Edit(obj));
        }       
        public IActionResult Delete(int id)
        {
            //app.Room.Delete(id);
            //return Redirect("/Admin/Room");
            return Json(app.Room.Delete(id));
        }        
    }
}