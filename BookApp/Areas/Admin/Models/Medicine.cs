using System;
namespace WebApp.Areas.Admin.Models
{
	public class Medicine
	{
		public string IdMedicine {get;set;}
		public string NameMedicine {get;set;}
		public string IdMeElement {get;set;}
		public string NameMeElement { get; set; }
		public string IdMeGroup { get; set; }
		public string MeGroupName { get; set; }
		public string IdProducer {get;set;}
		public string NameProducer { get; set; }
		public string Unit {get;set;}
	}
}