using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Doctor.Models
{
    public class SearchMedicine
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        //public string NameMedicine { get; set; }
        //public string NameMeElement { get; set; }
        public string MeGroupName { get; set; }
    }
}
