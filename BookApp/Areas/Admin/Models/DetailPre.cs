using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class DetailPre
    {
        public int Id { get; set; }
        public string IdPres { get; set; }
        public string  IdMedicine { get; set; }
        public int  Quantity { get; set; }
       public string  Dosage { get; set; }
        public string  Usage { get; set; }
        public string  Unit { get; set; }
    }
    public class DetailPreToShow
    {
        public int Id { get; set; }
        public string IdPres { get; set; }
        public string IdMedicine { get; set; }
        public int Quantity { get; set; }
        public string Dosage { get; set; }
        public string Usage { get; set; }
        public string Unit { get; set; }
        public string NameMedicine { get; set; }
    }
}
