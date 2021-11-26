using System;
namespace WebApp.Areas.Admin.Models
{
	public class Room
	{
		public int OrdinalRoom {get;set;}
		public string IdDept {get;set;}
        public string DeptName { get; set; }
        public string RoomName {get;set;}
		public int QuantityPatient {get;set;}
	}
}