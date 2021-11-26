using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class Precription
    {
        public string IdPres  { get; set; }
        public DateTime InDate { get; set; }
        public string IdPKB { get; set; }
        public string IdPatient { get; set; }
        public string IdEmp { get; set; }
        public string Diagnose { get; set; }
        public string Advice { get; set; }
        public string FollowAppoint { get; set; }
        public string NameEmp { get; set; }
        public string DeptName { get; set; }
        public string Images { get; set; }

    }
}
