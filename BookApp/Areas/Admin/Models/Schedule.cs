using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string IdEmp { get; set; }
        public DateTime Dated { get; set; }
        public string TimeRange { get; set; }
        public int OrdinalRoom { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }


    }
}
