using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Controllers;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Specialist_Doctor.Controllers
{
    [Area("Specialist_Doctor")]
    [Authorize(Roles = "Special-Doctor")]
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListSchedule()
        {
            return View(app.Employee.GetEmployee());
        }
        public IActionResult MakeSchedule()
        {
            ViewBag.idemp = User.FindFirst(ClaimTypes.NameIdentifier).ToString().Split(" ")[^1];
            ViewBag.ordinalroom = new SelectList(app.Room.GetRoom(), "OrdinalRoom","RoomName");
            ViewBag.department = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View(app.Department.GetDepartment());
        }
        public IActionResult GetDoctorByDepartment(string id)
        {
            return Json(app.Employee.GetDoctorByDepartment(id));
        }
        public IActionResult GetRoomByIdDept(string id)
        {
            return Json(app.Room.GetRoomByIdDept(id));
        }
        [HttpPost]
        public IActionResult GetSchedule(string id)
        {
            return Json(app.Schedule.GetSchedule(id));
        }
        public IActionResult GetScheduleById(int id)
        {
            return Json(app.Schedule.GetScheduleById(id));
        }

        //[HttpPost]
        //public IActionResult CreateSchedule(Schedule obj)
        //{
        //    return Json(app.Schedule.Add(obj));
        //}
        //public IActionResult EditSchedule(int id)
        //{
        //    return View(app.Schedule.GetScheduleById(id));
        //}
        [HttpPost]
        public IActionResult SaveSchedule(Schedule obj)
        {
            if (obj.Id == 0)
            {
                return Json(app.Schedule.Add(obj));
            }
            else
            {
                return Json(app.Schedule.Edit(obj));
            }

        }
        public IActionResult DeleteSchedule(int id)
        {
            return Json(app.Schedule.Delete(id));
        }
        public IActionResult GetTimeRange()
        {
            return Json(app.TimeRange.GetTimeRange());
        }
    }
}
