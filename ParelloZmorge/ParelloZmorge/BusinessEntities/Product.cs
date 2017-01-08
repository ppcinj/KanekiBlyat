using ParelloZmorge.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ParelloZmorge.BusinessEntities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Weight { get; set; }
		//orders in which the product exists
        public virtual List<ProductOrderLinkification> OrderProductLinkifications { get; set; }
    }
}