using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Controllers;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Doctor.Controllers
{
    [Area("Doctor")]
    [Authorize(Roles = "Doctor")]
    public class HomeController : BaseController
    {
        public IActionResult GetPatientByIdDocTor(string id)
        {
           
            return Json(app.Patient.GetPatientByIdDocTor(id));
        }
   
        public IActionResult ListPatient()
        {
            //đăng nhập bằng tài khoản của bác sĩ hay tài khoản của bệnh nhân?
            //nó không lấy được id bác sĩ
            //
            ViewBag.patients = app.Patient.GetPatientByIdDocTor(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View();
        }
       
            
       

        [HttpPost]
        public IActionResult AddPres(Precription obj, List<DetailPre> objs)
        {           
            int kq1 = app.Precription.Add(obj);
            int n = objs.Count;
            List<int> kq2 = new List<int>();
            if (kq1 != 0)
            {
                for (int i = 0; i < objs.Count; i++)
                {
                    kq2.Add(app.DetailPre.Add(objs[i]));
                }
                if (kq2.Sum() == n)
                {
                    return Json(kq2);
                }
                app.DetailPre.DeleteByIdPres(objs[0].IdPres);
                return Json(0);
            }
            return Json(0);

        }      
        
        public IActionResult DeletePres(string id)
        {
            app.Precription.Delete(id);
            return Redirect("/Doctor/Home/Prescription");
        }
        public IActionResult DeleteDetailPres(int id)
        {
            app.DetailPre.DeleteById(id);
            return Redirect("/Doctor/Home/Prescription");
        }
        public IActionResult GetPKBByIdEmp(string id)
        {
            return Json(app.PKB.GetPKBByIdEmp(id));
        }
        public IActionResult GetPKBByIdPatient(string id)
        {
            return Json(app.PKB.GetPKBByIdPatient(id));
        }
        public IActionResult Prescription()
        {
            ViewBag.melement = new SelectList(app.MeElement.GetMeElement(), "IdMeElement", "NameMeElement");
            ViewBag.megroup = new SelectList(app.Megroup.GetMeGroup(), "IdMeGroup", "MeGroupName");
            return View();
        }
        public IActionResult Appointment()
        {
            ViewBag.userId = User.FindFirst(ClaimTypes.NameIdentifier).ToString().Split(" ")[^1];
            return View();
        }
        //lấy theo id bệnh nhân thì phải truyền vào id bệnh nhân
        public IActionResult PatientProfile(string id)
        {
            ViewBag.pres = app.Patient.GetPresByIdPatient(id);           

            return View();
        }
        public IActionResult GetPresDetailByIdPres(string id)
        {
            return Json(app.DetailPre.GetPresDetailByIdPres(id));
        }
        public IActionResult Index()
        {
            //chỗ này đúng rồi
            string userid= User.FindFirst(ClaimTypes.NameIdentifier).ToString().Split(" ")[^1];
            ViewBag.userId = userid;
            ViewBag.sumexam = app.PKB.SumOfPatientExammedByDoctor(userid);
            ViewBag.sumtoday = app.PKB.SumOfPatientTodayByDoctor(userid);
            ViewBag.sumother = app.PKB.SumOfPatientFromToday(userid);
            return View();
        }
        public IActionResult MakeSchedule()
        {
            return View(app.Employee.GetEmployeeByPosition("Bác sĩ"));
        }
        public IActionResult SearchMedicine(string term)
        {
            return Json(app.Medicine.SearchMedicine(term));
        }



    }
}
