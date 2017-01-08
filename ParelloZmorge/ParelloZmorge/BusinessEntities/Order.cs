using ParelloZmorge.Enums;
using ParelloZmorge.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParelloZmorge.BusinessEntities
{
    public class Order
    {
        [Key]
        public int DataId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public OrderState State { get; set; }
        /// <summary>
        /// User which made this Order
        /// </summary>
        [Required]
        public virtual ApplicationUser User { get; set; }
        /// <summary>
        /// Ordered products.
        /// </summary>
        public virtual List<ProductOrderLinkification> OrderProductLinkifications{ get; set; }
    }
}