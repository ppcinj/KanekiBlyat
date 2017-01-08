using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParelloZmorge.BusinessEntities
{
	public class ProductOrderLinkification
	{
		[Key]
		public int Id { get; set; }
		public virtual Product Product { get; set; }
		public virtual Order Order { get; set; }
		public int Amount { get; set; }
	}
}