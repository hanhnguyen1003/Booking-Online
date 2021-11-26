using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class SearchDoctor
    {
        public string Name { get; set; }
        public bool? SexE { get; set; }
        public int? IdEdu { get; set; }
        public string IdDept { get; set; }
        public int? Schedule { get; set; }
    }
}
