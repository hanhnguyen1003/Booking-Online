using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class EmailRepository:BaseRepository
    {
        public int AddVerify(string email,string code)
        {
            Parameter[] parameters =
            {
                new Parameter{Name="@Email",Value=email,DbType=DbType.String},
                new Parameter{Name="@Code",Value=code,DbType=DbType.String}
            };
            return Save("AddVerify", parameters);
        }
        public Verify GetVerifyCode(string email)
        {
            Parameter parameter = new Parameter { Name = "@Email", Value = email, DbType = DbType.String };
            return GetSingle<Verify>("GetVerify", parameter, connectionString);
        }
        /// <summary>
        /// Xóa bảng Verify theo email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public int Delete(string email)
        {
            Parameter parameter = new Parameter { Name = "@Email", Value = email, DbType = DbType.String };
            return Save("DeleteVerify", parameter);
        }
        /// <summary>
        /// Gửi mail theo kiểu t= true là gửi xác nhận, t = false là gửi mật khẩu
        /// </summary>
        /// <param name="email"></param>
        /// <param name="message"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static async Task SendMailAsync(string email, string message, bool t)
        {
            Action action = () =>
            {
                string body;
                string subject;
                if (t)
                {
                    body = $"Mã xác nhận email của bạn là : {message}";
                    subject = "DBONLINE: gửi mã xác nhận";
                }
                else
                {
                    body = $"Mật khẩu mới của bạn là: {message}";
                    subject = "DBONLINE: gửi mật khẩu mới";
                }
                MailMessage m = new MailMessage();
                m.To.Add(email);
                m.Subject = subject;
                m.Body = body;
                m.From = new MailAddress("guitartot001@gmail.com");
                m.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = true;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("guitartot001@gmail.com", "gThanhLam411");
                smtp.Send(m);
            };
            Task task = new Task(action);
            task.Start();
            await task;
        }
    }
}
