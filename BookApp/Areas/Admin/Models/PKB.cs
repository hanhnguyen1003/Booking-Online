using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class PKB
    {
        public string IdPKB { get; set; }
        public int STTPatient { get; set; }
        public string IdDept { get; set; }
        public string DeptName { get; set; }
        public int OrdinalRoom { get; set; }
        public string RoomName { get; set; }
        public int Price { get; set; }
        public string IdEmp { get; set; }
        public string NameEmp { get; set; }
        public string IdPatient { get; set; }
        public string NamePatient { get; set; }
        public bool SexP { get; set; }
        public string AddP { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        //public string Idjob { get; set; }
        //public string JobName { get; set; }


        public DateTime DOB { get; set; }
        public DateTime Dated { get; set; }
        public int IdSes { get; set; }
        public string Ses { get; set; }
        public string RangeTime { get; set; }
        public string PaymentCode { get; set; }

    }
}
