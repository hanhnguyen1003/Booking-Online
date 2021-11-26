using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Patient.Models
{
    public class DoctorInfo
    {

        public int ScheduleId{ get; set; }
        public DateTime Dated { get; set; }
        public string IdEmp { get; set; }
        public string NameEmp { get; set; }
        public int IdEdu { get; set; }
        public string EduName { get; set; }
        public string IdDept { get; set; }
        public string DeptName { get; set; }
        public string   TimeRange { get; set; }
        public int OrdinalRoom { get; set; }
        public string Images { get; set; }
        public bool SexE { get; set; }

    }
}
