using System;
using System.Collections.Generic;

namespace WebApp.Areas.Admin.Models
{
	public class TimeRange
	{
		public int IdPeriod { get; set; }
		public int IdSes { get; set; }
		public string Ses { get; set; }
		public string RangeTime { get; set; }

	}
}