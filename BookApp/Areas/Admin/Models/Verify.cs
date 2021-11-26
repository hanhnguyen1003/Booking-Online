using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class Verify
    {
        public string Email { get; set; }
        public string Code { get; set; }
        public DateTime Dated { get; set; }
    }
}
