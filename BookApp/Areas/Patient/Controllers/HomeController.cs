using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Controllers;
using WebApp.Areas.Admin.Models;
using WebApp.Areas.Patient.Models;

namespace WebApp.Areas.Patient.Controllers
{
    [Area("Patient")]
    [Authorize(Roles = "Patient")]
    [EnableCors("AllowOrigin")]
    public class HomeController : BaseController
    {
        public IActionResult GetTimeRange()
        {
            return Json(app.TimeRange.GetTimeRange());
        }
        readonly APICheckout api = new APICheckout();

        public IActionResult Index()
        {
            ViewBag.province = new SelectList(app.DVHC.GetProvince(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult GetDVHCByParentID(int id)
        {
            return Json(app.DVHC.GetDVHCByParentId(id));
        }
        public IActionResult SendSMS()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SMS(string p, string m)
        {
            /*
             Người dùng gửi số điện thoại
            hệ thống tự sinh mã gửi cho khách hàng
            khách hàng điền mã xác nhận và gủi cho hệ thống
            hệ thống gửi lại thông tin đăng ký thành công
            Mã tự sinh và số điện thoại sẽ được lưu vào SQL
             */
            await Task.Yield();
            SMS sms = new SMS();
            return Json(sms.Send(p, m));
        }
        public IActionResult BookingByDoctor()
        {
            ViewBag.edu = new SelectList(app.Education.GetEducation(), "IdEdu", "EduName");
            ViewBag.dept = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View(app.Department.GetDepartment());
        }
        public IActionResult GetDoctorById(string id)
        {
            return Json(app.Employee.GetEmployeeByIdEmp(id));
        }

        public IActionResult BookDoctor()
        {
            return View(app.Department.GetDepartment());
        }
        public IActionResult SearchDoctor(SearchDoctor obj)
        {
            return Json(app.Employee.SearchDoctor(obj));
        }
        public IActionResult GetDoctors(int pagenumber, int rowofpage)
        {
            return Json(app.Employee.GetDoctors(pagenumber, rowofpage));
        }
        public IActionResult CheckNumberDoctor()
        {
            return Json(app.Employee.GetDoctors(1, 1000).Count);
        }
        public IActionResult GetScheduleByDoctor(string id)
        {
            return Json(app.Schedule.GetScheduleByDoctor(id, true));
        }
        public IActionResult BookingByDay()
        {
            //ViewBag.edu = new SelectList(app.Education.GetEducation(), "IdEdu", "EduName");
            //ViewBag.dept = new SelectList(app.Department.GetDepartment(), "IdDept", "DeptName");
            return View();
        }
        public IActionResult GetTimeRangeExceed(string dated, string idemp)
        {
            return Json(app.TimeRange.GetTimeRangeExceed(dated, idemp));
        }
        public IActionResult ViewPres(string id)
        {
            PKB res = app.PKB.GetPKBByID(id);
            ViewBag.patientinfo = app.Patient.GetPatientByIdPatient(res.IdPatient);
            return View(res);
        }
        public IActionResult DeletePKB(string id)
        {
            return Json(app.PKB.Delete(id));
        }
        public IActionResult ConfirmInfo()
        {
            return View();
        }
        public IActionResult ChooseDoctor()
        {
            return View();
        }
        public IActionResult GetRoom()
        {
            return Json(app.Room.GetRoom());
            ;
        }
        [HttpPost]
        public IActionResult GetEducationByIdEmp(string id)
        {
            return Json(app.Education.GetEducationByIdEmp(id));
        }
        [HttpPost]

        public IActionResult GetDepartmentByIdEmp(string id)
        {
            return Json(app.Department.GetDepartmentByIdEmp(id));
        }
        public IActionResult GetCurrentWeekSchedule()
        {
            return Json(app.Schedule.GetCurrentWeekSchedule());
        }
        public IActionResult GetScheduleAvailable()
        {
            return Json(app.Schedule.GetScheduleAvailable());
        }
        public IActionResult GetDepartmentByDate(DateTime dated)
        {
            return Json(app.Schedule.GetDepartmentByDate(dated));
        }
        public IActionResult GetDoctorByDate(DateTime dated, string idDept)
        {
            return Json(app.Schedule.GetDoctorByDate(dated, idDept));
        }
        public IActionResult GetScheduleByDeptAndDate(DateTime dated, string idDept)
        {
            return Json(app.Schedule.GetScheduleByDateAndDeptId(dated, idDept));
        }
        public IActionResult SetExpressCheckout(RequestInfo obj, string method)
        {

            ResponseInfo result = api.GetUrlCheckout(obj, method);

            if (result.Error_code == "00")
            {
                return Redirect(result.Checkout_url);
            }
            else
            {
                return Json(result.Description);
            }
        }
        //trang thanh toán, chọn hình thức thanh toán
        public IActionResult Pay()
        {
            //truyền vào danh sách các ngân hàng được hỗ trợ?, hình ảnh và bank code
            return View();
        }
        //truyền xuognos số tiền, mã ngân hàng, nội dung, hàm này chuyển về trang thanh toán của NVPay
        [HttpPost]
        public IActionResult Payment(int money, string content)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(GetBasePath()).AddJsonFile("appsettings.json").Build();
            var config = configuration.GetSection("VNPAY");
            string url = config["Url"];
            string returnUrl = config["ReturnUrl"];
            string tmnCode = config["TmnCode"];
            string hashSecret = config["HashSecret"];

            PayLib pay = new PayLib();

            pay.AddRequestData("vnp_Version", "2.0.0"); //Phiên bản api mà merchant kết nối. Phiên bản hiện tại là 2.0.0
            pay.AddRequestData("vnp_Command", "pay"); //Mã API sử dụng, mã cho giao dịch thanh toán là 'pay'
            pay.AddRequestData("vnp_TmnCode", tmnCode); //Mã website của merchant trên hệ thống của VNPAY (khi đăng ký tài khoản sẽ có trong mail VNPAY gửi về)
            pay.AddRequestData("vnp_Amount", (money * 100).ToString()); //số tiền cần thanh toán, công thức: số tiền * 100 - ví dụ 10.000 (mười nghìn đồng) --> 1000000
            pay.AddRequestData("vnp_BankCode", ""); //Mã Ngân hàng thanh toán (tham khảo: https://sandbox.vnpayment.vn/apis/danh-sach-ngan-hang/), có thể để trống, người dùng có thể chọn trên cổng thanh toán VNPAY
            pay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss")); //ngày thanh toán theo định dạng yyyyMMddHHmmss
            pay.AddRequestData("vnp_CurrCode", "VND"); //Đơn vị tiền tệ sử dụng thanh toán. Hiện tại chỉ hỗ trợ VND
            pay.AddRequestData("vnp_IpAddr", HttpContext.Connection.RemoteIpAddress.ToString()); //Địa chỉ IP của khách hàng thực hiện giao dịch
            pay.AddRequestData("vnp_Locale", "vn"); //Ngôn ngữ giao diện hiển thị - Tiếng Việt (vn), Tiếng Anh (en)
            pay.AddRequestData("vnp_OrderInfo", content); //Thông tin mô tả nội dung thanh toán
            pay.AddRequestData("vnp_OrderType", "other"); //topup: Nạp tiền điện thoại - billpayment: Thanh toán hóa đơn - fashion: Thời trang - other: Thanh toán trực tuyến
            pay.AddRequestData("vnp_ReturnUrl", returnUrl); //URL thông báo kết quả giao dịch khi Khách hàng kết thúc thanh toán
            pay.AddRequestData("vnp_TxnRef", DateTime.Now.Ticks.ToString()); //mã hóa đơn

            string paymentUrl = pay.CreateRequestUrl(url, hashSecret);

            return Json(paymentUrl);
        }
        public IActionResult PaymentConfirm()
        {
            var vnpayData = HttpContext.Request.QueryString;
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(GetBasePath()).AddJsonFile("appsettings.json").Build();
            var config = configuration.GetSection("VNPAY");
            string hashSecret = config["HashSecret"]; //Chuỗi bí mật             
            PayLib pay = new PayLib();
            Console.WriteLine(vnpayData);
            foreach (string s in vnpayData.ToString().Replace("?", "").Split("&"))
            {
                Console.WriteLine(s);
                //if (!string.IsNullOrEmpty(s) && s.StartsWith("vnp_"))
                //{
                pay.AddResponseData(s.Split("=")[0], s.Split("=")[1]);
                //}
            }
            long orderId = Convert.ToInt64(pay.GetResponseData("vnp_TxnRef")); //mã hóa đơn
            Console.WriteLine($"orderId {orderId}");
            long vnpayTranId = Convert.ToInt64(pay.GetResponseData("vnp_TransactionNo")); //mã giao dịch tại hệ thống VNPAY
            Console.WriteLine($"tranId {vnpayTranId}");
            string vnp_ResponseCode = pay.GetResponseData("vnp_ResponseCode"); //response code: 00 - thành công, khác 00 - xem thêm https://sandbox.vnpayment.vn/apis/docs/bang-ma-loi/
            string vnp_SecureHash = pay.GetResponseData("vnp_SecureHash"); //hash của dữ liệu trả về

            bool checkSignature = pay.ValidateSignature(vnp_SecureHash, hashSecret); //check chữ ký đúng hay không?
            Console.WriteLine($"response {vnp_ResponseCode}");
            Console.WriteLine($"securehash {vnp_SecureHash}");
            Console.WriteLine($"checksign {checkSignature}");

            //if (checkSignature)
            //{
            if (vnp_ResponseCode == "00")
            {
                DetailTransaction obj = new DetailTransaction
                {
                    vnp_Amount = pay.GetResponseData("vnp_Travnp_AmountnsactionNo"),
                    vnp_BankCode = pay.GetResponseData("vnp_BankCode"),
                    vnp_BankTranNo = pay.GetResponseData("vnp_BankTranNo"),
                    vnp_CardType = pay.GetResponseData("vnp_CardType"),
                    vnp_OrderInfo = pay.GetResponseData("vnp_OrderInfo"),
                    vnp_PayDate = pay.GetResponseData("vnp_PayDate"),
                    vnp_ResponseCode = pay.GetResponseData("vnp_ResponseCode"),
                    vnp_TmnCode = pay.GetResponseData("vnp_TmnCode"),
                    vnp_TransactionNo = pay.GetResponseData("vnp_TransactionNo"),
                    vnp_TxnRef = pay.GetResponseData("vnp_TxnRef"),
                    vnp_SecureHashType = pay.GetResponseData("vnp_SecureHashType"),
                    vnp_SecureHash = pay.GetResponseData("vnp_SecureHash"),
                    orderId = pay.GetResponseData("orderId"),
                    tranId = pay.GetResponseData("tranId")
                };
                app.DetailTransaction.Add(obj);
                foreach (var idpb in obj.vnp_OrderInfo.Split("%2C"))
                {
                    app.PKB.AddTransactionIdToPKB(idpb, obj.vnp_TransactionNo);
                }
                //Thanh toán thành công
                ViewBag.Message = "Thanh toán thành công hóa đơn " + orderId + " | Mã giao dịch: " + vnpayTranId;
            }
            else
            {
                //Thanh toán không thành công. Mã lỗi: vnp_ResponseCode
                ViewBag.Message = "Có lỗi xảy ra trong quá trình xử lý hóa đơn " + orderId + " | Mã giao dịch: " + vnpayTranId + " | Mã lỗi: " + vnp_ResponseCode;
            }
            //}
            //else
            //{
            //    ViewBag.Message = "Có lỗi xảy ra trong quá trình xử lý";
            //}


            return View();
        }
        private static string GetBasePath()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var isDevelopment = environment == Environments.Development;
            if (isDevelopment)
            {
                Console.WriteLine("Access to the development enviroiment");
                return Directory.GetCurrentDirectory();
            }
            using var processModule = Process.GetCurrentProcess().MainModule;
            Console.WriteLine("Access to the deploy enviroiment");
            return Path.GetDirectoryName(processModule?.FileName);
        }
    }

}
