using System.ComponentModel.DataAnnotations;

namespace Bakery.Data.Model.Models
{
	public class OrderItem
	{
		[Key]
		public int Id { get; set; }
		public int ProductCount { get; set; }
		public decimal Price { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }

		public int OrderId { get; set; }
		public Order Order { get; set; }
	}
}
