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
    public class TimeRangeController : BaseController
    {
        public IActionResult Index()
        {
            return View(app.TimeRange.GetTimeRange());
        }
        public IActionResult Create()
        {
            ViewBag.ses = new SelectList(app.Ses.GetSes(), "IdSes", "Ses");
            return View();
        }
        [HttpPost]
        public IActionResult Create(TimeRange obj)
        {
            app.TimeRange.Add(obj);
            return Redirect("/Admin/TimeRange");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.department = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View(app.TimeRange.GetTimeRangeByIdPeriod(id));
        }
        [HttpPost]
        public IActionResult Edit(TimeRange obj)
        {
            app.TimeRange.Edit(obj);
            return Redirect("/Admin/TimeRange");
        }
        public IActionResult Delete(int id)
        {
            app.TimeRange.Delete(id);
            return Redirect("/Admin/TimeRange");
        }
    }
}