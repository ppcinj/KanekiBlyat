using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParelloZmorge.Models
{
	public class OrderListViewModel
	{
		public IList<OrderModel> Orders { get; set; }
	}
}