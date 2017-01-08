using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParelloZmorge.Enums;

namespace ParelloZmorge.Models
{
	public class OrderModel
	{
		public int Id { get; set; }
		public IList<OrderProductModel> OrderedProducts { get; set; }
		public ApplicationUserModel User { get; set; }
        public OrderState OrderState { get; set; }
	}
}