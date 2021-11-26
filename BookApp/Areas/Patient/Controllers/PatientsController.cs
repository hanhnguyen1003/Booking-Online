using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Controllers;
using WebApp.Areas.Admin.Models;
using WebApp.Areas.Patient.Models;

namespace WebApp.Areas.Patient.Controllers
{
    [Area("Patient")]
    [Authorize(Roles = "Patient")]
    public class PatientsController : BaseController
    {
        public IActionResult MedicineBill(string id)
        {            
            return View(app.Patient.GetPatientByIdPatient(id));
        }
        public static string FixBase64ForImage(string Image)
        {
            System.Text.StringBuilder sbText = new StringBuilder(Image, Image.Length);
            sbText.Replace("\r\n", string.Empty); sbText.Replace(" ", string.Empty);
            return sbText.ToString();
        }
        public IActionResult SendSMS(PKB obj, string phone, string voucher,string dataurl)
        {
            byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage(dataurl));
            MemoryStream streamBitmap = new MemoryStream(bitmapData);
            string to = app.Patient.GetPatientByIdPatient(obj.IdPatient).Email;          
            string subject = "Phiếu đăng ký khám bệnh của: " + obj.NamePatient;           
            MailMessage mm = new MailMessage();          
            mm.IsBodyHtml = true;
            AlternateView av = AlternateView.CreateAlternateViewFromString(voucher, null, mm.IsBodyHtml ? MediaTypeNames.Text.Html : MediaTypeNames.Text.Plain);
            LinkedResource imageToInline = new LinkedResource(streamBitmap, MediaTypeNames.Image.Jpeg);
            imageToInline.ContentId = "hinhmavach";
            imageToInline.ContentType = new ContentType("image/jpg");
            av.LinkedResources.Add(imageToInline);           
            mm.AlternateViews.Add(av);
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = voucher;          
            mm.From = new MailAddress("tantamhospital@gmail.com","Tận Tâm Hospital");  
            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = true,
                EnableSsl = true,
                Credentials = new System.Net.NetworkCredential("mainguyen170599@gmail.com", "mainguyenbl")
            };
            smtp.Send(mm);
            SMS sms = new SMS();
            //hàm convertounsign chuyển tiếng việt có dấu sáng không dấu
            sms.Send(phone, ConvertToUnSign($"Ma phieu kham cua ban la: {obj.IdPKB}"));
            return Json("ok");
        }

        [HttpPost]
        public IActionResult AddPKB(List<PKB> objs)
        {
            List<PKB> ret = new List<PKB>();
            if (objs.Count > 0)
            {
                var time = DateTime.Now;
                int stt = app.PKB.GetCurrentRow();               
                objs.ForEach(obj =>
                {
                    obj.IdPKB = $"{time.Year.ToString().Substring(0, 2)}{("0" + time.Month)[^2..]}{("0" + time.Day)[^2..]}{stt}";
                    obj.STTPatient = ++stt;
                    if (app.PKB.Add(obj) != 0)
                    {
                        ret.Add(obj);
                    }
                });
            }
            return Json(ret);
        }
        public IActionResult AddPKB()
        {
            return View();
        }
        public IActionResult GetPKB(string id)
        {
            return Json(app.PKB.GetPKBByID(id));
        }
        public IActionResult ChooseProfile()
        {

            if (User.Identity.IsAuthenticated)
            {

                string phone = User.Identity.Name;
                return View(app.Patient.GetPatientByPhone(phone));
            }
            return Redirect("/");

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patients obj)
        {
            obj.Phone = User.Identity.Name;
            app.Patient.Add(obj);
            return Redirect("/");
        }

        public IActionResult Create()
        {
            ViewBag.province = new SelectList(app.DVHC.GetProvince(), "Id", "Name");
            ViewBag.job = new SelectList(app.Job.GetJob(), "Idjob", "JobName");
            return View();
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            Patients e = app.Patient.GetPatientByIdPatient(id);
            ViewBag.province = new SelectList(app.DVHC.GetProvince(), "Id", "Name");
            ViewBag.district = new SelectList(app.DVHC.GetDVHCByParentId(e.City), "Id", "Name");
            ViewBag.village = new SelectList(app.DVHC.GetDVHCByParentId(e.District), "Id", "Name");
            ViewBag.job = new SelectList(app.Job.GetJob(), "Idjob", "JobName");

            return View(e);
        }
        [HttpPost]
        public IActionResult Edit(Patients obj)
        {
            app.Patient.Edit(obj);
            return Redirect("/Patient/Patients/ChooseProfile");
            //return Json(app.Employee.Edit(obj));
        }
        public IActionResult Delete(string id)
        {
            app.Patient.Delete(id);
            return Redirect("/Patient/Patients/ChooseProfile");
        }
        // [Authorize(Roles ="")]
        public IActionResult GetDVHCByParentID(int id)
        {
            return Json(app.DVHC.GetDVHCByParentId(id));
        }
        public IActionResult GetJobByIdJob(int id)
        {
            return Json(app.Job.GetJobByIdjob(id));
        }
        public IActionResult Upload(IFormFile f)
        {
            if (f != null)
            {
                //Lay ten tap tin
                string fileName = string.Join("", f.FileName.Split(" "));
                string path = Directory.GetCurrentDirectory() + "/wwwroot/assets/img/patients/";
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
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\assets\\img\\patients", id);
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
        public IActionResult ProfilePatient()
        {

            if (User.Identity.IsAuthenticated)
            {

                string phone = User.Identity.Name;
                return View(app.Patient.GetPatientByPhone(phone));
            }
            return Redirect("/");
        }
        
        public IActionResult ManageMB(string id)
        {
            //ViewBag.userId = User.FindFirst(ClaimTypes.NameIdentifier).ToString().Split(" ")[^1];          
            return View(app.PKB.GetPKBByIdPatient(id));
        }
        public IActionResult GetPatientByIdPatient(string id)
        {
            return Json(app.Patient.GetPatientByIdPatient(id));
        }
        private static string ConvertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }

}

