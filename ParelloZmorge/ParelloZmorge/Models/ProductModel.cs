using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ParelloZmorge.Models
{
	public class ProductModel
	{
		[Required]
		public string Description { get; set; }
		[ScaffoldColumn(false)]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		[DisplayFormat(DataFormatString = "{0:C2}")]
		[DataType(DataType.Currency)]
		public decimal? Price { get; set; }
		[Required]
		[DisplayFormat(DataFormatString = "{0:F2}")]
		public decimal Weight { get; set; }
		[DataType(DataType.ImageUrl)]
		[UIHint("ImageEditor")]
		public ImageUploadModel ImageUploadModel { get; set; }
	}

	public class ImageUploadModel
	{
		public int? Id { get; set; }
	}
}