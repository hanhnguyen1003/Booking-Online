using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Patient.Models
{
    public class OTPS
    {
        public string Phone { get; set; }
        public string OTP { get; set; }
        public DateTime Dated { get; set; }
    }
}
