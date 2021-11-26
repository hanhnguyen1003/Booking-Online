using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApp.Areas.Users.Models;

namespace WebApp.Areas.Admin.Models
{
	public class Employee
	{
		public string IdEmp {get;set;}
		public string NameEmp {get;set;}
		public string Phone {get;set;}
        public string Username { get; set; }
        public string Password { get; set; }
        public string AddE {get;set;}
		public string Email {get;set;}
        public int City { get; set; }
        public int District{ get; set; }
        public int Village { get; set; }
        public bool SexE {get;set;}
		public int IdEdu {get;set;}
        public string EduName { get; set; }
        public string IdDept {get;set;}
        public string DeptName { get; set; }
		public string Images { get; set; }
		public string ImagesDept { get; set; }
        public int Price { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime? DOB { get; set; }
        public string Position { get; set; }
        public List<Role> Roles { get; set; }
    }
}