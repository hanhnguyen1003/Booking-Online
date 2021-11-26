using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Patient.Models
{
    public class SMS
    {
        readonly clsSMS objclsSMS = new clsSMS();
        SerialPort searialPort = new SerialPort();
        public string Send(string phone, string message)
        {
            if (!string.IsNullOrEmpty(FindPortAndConnect()))
            {
                //return FindPortAndConnect();
                //searialPort = objclsSMS.OpenPort("COM6", Convert.ToInt32(9600), Convert.ToInt32(8), Convert.ToInt32(100), Convert.ToInt32(100));
                try
                {

                    if (objclsSMS.sendMsg(searialPort, phone, message, 5000))
                    {
                        objclsSMS.ClosePort(searialPort);
                        return $"Gửi tin nhắn cho số {phone}. Nội dung: {message} THÀNH CÔNG";
                    }
                    objclsSMS.ClosePort(searialPort);
                    return $"Gửi tin nhắn cho số {phone}. Nội dung: {message} THẤT BẠI";
                }
                catch (Exception ex)
                {
                    objclsSMS.ClosePort(searialPort);
                    return ex.ToString();
                }
            }
            return "Không thể kết nối tới DCOM";
        }
        string FindPortAndConnect()
        {
            string result = null;
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                try
                {
                    searialPort = objclsSMS.OpenPort(port, Convert.ToInt32(115200), Convert.ToInt32(8), Convert.ToInt32(100), Convert.ToInt32(100));
                    bool isConnect = objclsSMS.CheckPortSendSMS(searialPort);
                    if (isConnect)
                    {
                        return port;
                    }
                }
                catch
                {

                    result = null;
                }

            }
            return result;
        }
    }
}
