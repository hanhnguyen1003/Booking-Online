using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Areas.Admin.Controllers;

namespace WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.edu = new SelectList(app.Education.GetEducation(), "IdEdu", "EduName");
            ViewBag.dept = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View(app.Department.GetDepartment());
        }
        public IActionResult GetPKBByID(string pkb)
        {
            return Json(app.PKB.GetPKBByID(pkb));
        }
        public IActionResult ByDoctor()
        {
            /*
             viết hàm sql lấy danh sách employee theo mã 
             */
            return View(app.Employee.GetEmployeeByPosition("Bác sĩ"));
        }
        public IActionResult ByDate()
        {
            return View();
        }
        public IActionResult Intro()
        {
            return View();
        }
        public IActionResult Quytrinh()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Thacmac()
        {
            return View();
        }
    }
}
