using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParelloZmorge.Models
{
	public class OrderProductModel: ProductModel
	{
		public int Amount { get; set; }
		public decimal Total => Amount*Price.Value;
	}
}