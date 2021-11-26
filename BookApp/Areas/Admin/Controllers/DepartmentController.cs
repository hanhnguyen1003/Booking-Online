using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using WebApp.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DepartmentController : BaseController
    {
        public IActionResult Index()
        {
            return View(app.Department.GetDepartment());
        }       
        //public IActionResult Create()
        //{            
        //    return View();
        //}
        [HttpPost]
        public IActionResult GetDepartment()
        {
            return Json(app.Department.GetDepartment());
        }
        [HttpPost]       
        public IActionResult Create(Department obj)
        {
            //app.Department.Add(obj);
            //return Redirect("/Admin/Department");
            return Json(app.Department.Add(obj));
        }       
        public IActionResult Edit(string id)
        {
            return View(app.Department.GetDepartmentByIdDept(id));
        }
        [HttpPost]      
        public IActionResult Edit(Department obj)
        {
            //app.Department.Edit(obj);
            //return Redirect("/Admin/Department");
            return Json(app.Department.Edit(obj));
        }    
        [HttpPost]
        public IActionResult Delete(string id)
        {
            //app.Department.Delete(id);
            return Json(app.Department.Delete(id));
        }

        public IActionResult Upload(IFormFile f)
        {
            if (f != null)
            {
                //Lay ten tap tin
                string fileName = string.Join("", f.FileName.Split(" "));
                string path = Directory.GetCurrentDirectory() + "/wwwroot/assets/img/specialities/";
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
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\assets\\img\\specialities", id);
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