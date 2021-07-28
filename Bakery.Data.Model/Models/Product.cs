using System.ComponentModel.DataAnnotations;

namespace Bakery.Data.Model.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal UnitPrice { get; set; }

		public int CategoryId { get; set; }
		public ProductCategory Category { get; set; }
	}
}
