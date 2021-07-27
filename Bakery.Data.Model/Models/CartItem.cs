using System;

namespace Bakery.Data.Model.Models
{
	public class CartItem
	{
		public int Id { get; set; }

		public int ProductCount { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }

		public int ShoppingCartId { get; set; }
		public ShoppingCart ShoppingCart { get; set; } 
	}
}
