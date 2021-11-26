using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : BaseController
    {
        public IActionResult Index()
        {
            return View(app.Employee.GetEmployee());
        }
        public IActionResult Create()
        {
            ViewBag.province = new SelectList(app.DVHC.GetProvince(), "Id", "Name");
            ViewBag.education = new SelectList(app.Education.GetEducation(), "IdEdu", "EduName");
            ViewBag.department = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View();
        }

        public IActionResult CheckUsername(string username)
        {
            return Json(app.Employee.CheckUsername(username));
        }
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            return Json(app.Employee.Add(obj));
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            Employee e = app.Employee.GetEmployeeByIdEmp(id);
            ViewBag.province = new SelectList(app.DVHC.GetProvince(), "Id", "Name");
            ViewBag.district = new SelectList(app.DVHC.GetDVHCByParentId(e.City), "Id", "Name");
            ViewBag.village = new SelectList(app.DVHC.GetDVHCByParentId(e.District), "Id", "Name");
            ViewBag.education = new SelectList(app.Education.GetEducation(), "IdEdu", "EduName");
            ViewBag.department = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View(e);
        }
        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            app.Employee.Edit(obj);
            return Redirect("/Admin/Employee");
            //return Json(app.Employee.Edit(obj));
        }
        public IActionResult Delete(string id)
        {
            app.Employee.Delete(id);
            return Redirect("/Admin/Employee");
        }
        // [Authorize(Roles ="")]
        public IActionResult GetDVHCByParentID(int id)
        {
            return Json(app.DVHC.GetDVHCByParentId(id));
        }
        public IActionResult Upload(IFormFile f)
        {
            if (f != null)
            {
                //Lay ten tap tin
                string fileName = string.Join("", f.FileName.Split(" "));
                string path = Directory.GetCurrentDirectory() + "/wwwroot/assets/img/doctors/";
                using (Stream stream = System.IO.File.Create(path + fileName))
                {
                    //Luu vao tap tin
                    f.CopyTo(stream);
                }
                return Json("Thành công");
            }
            return Json("Thất bại");
        }
        public IActionResult DeleteImage(string id)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\assets\\img\\doctors", id);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return Json("Xóa thành công ảnh " + id);
            }
            else
            {
                return Json("Không có ảnh nào trong dữ liệu");
            }

        }
    }
}