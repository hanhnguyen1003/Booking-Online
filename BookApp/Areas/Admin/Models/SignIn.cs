using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class SignIn
    {
        public string Usr { get; set; }
        public string Pwd { get; set; }
        public bool Remember { get; set; }
    }
}
