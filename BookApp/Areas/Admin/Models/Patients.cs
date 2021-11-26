using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class Patients
    {
        public String IdPatient { get; set; }
        public String NamePatient { get; set; }
        public DateTime? DOB { get; set; }
        public bool  SexPatient { get; set; }
        public Int64 Ident { get; set; }//cmnd
        public string Phone { get; set; }
        public string SubPhone { get; set; }
        public int Idjob { get; set; }

        public String JobName { get; set; }
        public String MeCode { get; set; } //ma the kham benh
        public DateTime? IssueDate  { get; set; }//ngay capnthe
        public bool MeStatus { get; set; }//trang thai the
        public String AddP { get; set; }
        public String Email { get; set; }
        public int City { get; set; }
        public int District { get; set; }
        public int Village { get; set; }
        public string ImageP { get; set; }



    }
}
