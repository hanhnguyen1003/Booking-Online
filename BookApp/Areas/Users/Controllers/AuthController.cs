using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Controllers;
using WebApp.Areas.Admin.Models;
using WebApp.Areas.Patient.Models;
using WebApp.Areas.Users.Models;

namespace WebApp.Areas.Users.Controllers
{
    [Area("Users")]
    public class AuthController : BaseController
    {
        public async Task<IActionResult> SendOTP(string phone)
        {
            //xóa OTP cũ nếu có dưới SQL
            app.OTP.DeleteOTP(phone);
            await Task.Yield();
            int otp = new Random().Next(100000, 999999);
            //thêm vào OTP dưới SQL
            app.OTP.AddOTP(phone, otp.ToString());
            SMS sms = new SMS();
            return Json(sms.Send(phone, "MH Medical: Ma OTP cua ban la: " + otp.ToString()));
        }
        public IActionResult VerifyOTP(string phone, string otp)
        {
            //lấy OTP dưới SQL lên
            OTPS o = app.OTP.GetOTPByPhoneAndOTP(phone, otp);
            if (o != null)           
                {
                if ((DateTime.Now - o.Dated).TotalSeconds < 300)
                {

                    List<Claim> claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.NameIdentifier, o.Phone),
                    new Claim(ClaimTypes.Name, o.Phone)
                    };
                    claims.Add(new Claim(ClaimTypes.Role, "Patient"));

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    AuthenticationProperties properties = new AuthenticationProperties
                    {
                        AllowRefresh = true
                    };
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), properties);
                    return Json("OK");
                }
                else
                {
                    return Json("Mã OTP hết hạn");
                }
            }
            else
            {
                return Json("Mã OTP không hợp lệ");
            }

        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerifyEmail(string email)
        {
            /*mình gửi cho nó đoạn code để xác nhận
           xong gửi thành công return lại thông báo thành công
            trên view sẽ hiện phần để xác nhận
            sau khi nhập mã xác nhận vô thì truyền mã đó xuống action ConfirmEmail
          */
            Employee employee = app.Employee.GetEmployeeByEmail(email);
            if (employee != null)
            {
                string code = Helper.RandomString(16);
                int status = app.Email.AddVerify(email, code);
                if (status == 1)
                {
                    await EmailRepository.SendMailAsync(email, code, true);
                    return Json("OK");
                }
                return Json("Không thể gửi mail");

            }
            return Json("Email không tồn tại");
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(string email, string code)
        {/*
          * so sánh confirm với mã gốc vừa gửi cho email
          * nếu khớp, sinh một mật khẩu mới rồi gửi về email
          * sau khi gửi mail thì gửi trả về trạng thái thành công 
          * sau khi thành công thì chuyển về trang signin
          */
            Verify verify = app.Email.GetVerifyCode(email);
            if (verify != null)
            {
                string pass = Helper.RandomString(16);
                Employee employee = app.Employee.GetEmployeeByEmail(email);
                //đổi mật khẩu dưới sql
                app.Employee.ChangePass(employee.Username, pass);
                app.Email.Delete(email);
                await EmailRepository.SendMailAsync(email, pass, false);
                return Json("OK");
            }
            return Json("Mã xác thực không đúng");
        }
        [Authorize]
        public IActionResult ChangePass()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult ChangePass(ChangePass obj)
        {
            if (obj.NewPassword == obj.ConfirmPassword && obj.CurrentPassword != "")
            {
                string name = User.Identity.Name;
                Employee list = app.Employee.SignIn(name, obj.CurrentPassword);
                if (list != null)
                {
                    return Json(app.Employee.ChangePass(name, obj.NewPassword));
                }
                else
                {
                    return Json("Mật khẩu cũ không khớp");
                }
            }
            else
            {
                return Json("Mật khẩu không trùng nhau");
            }

            //truyền tên đăng nhập và mật khẩu cũ xuống kiểm tra xem có không? 
            //nếu mật khẩu không khớp thì trả về lỗi Json(0)
            //Nếu mật khẩu cũ đúng, thì truyefn username với mật khẩu mới xuống update lại mật khẩu




        }
        public IActionResult Denied()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/users/auth/signin");
        }
        [HttpPost]
        public IActionResult SignIn(SignIn obj)
        {
            //int ret;
            Employee em = app.Employee.SignIn(obj.Usr, obj.Pwd);
            //return Json(app.Employee.SignIn(username, pass));
            if (em != null)
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, em.IdEmp),
                    new Claim(ClaimTypes.Name, em.Username),
                    new Claim(ClaimTypes.Email, em.Email),
                    new Claim(ClaimTypes.MobilePhone, em.Phone)
                };
                List<Role> roles = app.Employee.GetRoleByEmployeeId(em.IdEmp);
                foreach (Role role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.RoleName));
                }
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = obj.Remember
                };
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), properties);
                return Redirect("/users/auth/RedirectByRole");
            }
            else
            {
                return Redirect("/users/auth/signin");
            }
        }
        public IActionResult GetUserInfo()
        {
            return Json(app.Employee.GetEmployeeByIdEmp(User.FindFirst(ClaimTypes.NameIdentifier).ToString().Split(" ")[^1]).NameEmp);
        }
        public IActionResult RedirectByRole()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Admin"))
                {
                    return Redirect("/admin/home/index");
                }
                else if (User.IsInRole("Doctor"))
                {
                    return Redirect("/doctor/home/index");
                }
                else if (User.IsInRole("Special-Doctor"))
                {
                    return Redirect("/Specialist_Doctor/home/index");
                }
                else
                {
                    return Redirect("/");
                }
            }
            else
            {
                return Redirect("/users/auth/signin");
            }
        }

    }
}
