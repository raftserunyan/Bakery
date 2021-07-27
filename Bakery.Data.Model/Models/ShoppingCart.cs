using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Data.Model.Models
{
	public class ShoppingCart
	{
		[Key]
		public int Id { get; set; }

		
		public int CustomerId { get; set; }
		[ForeignKey("CustomerId")]
		public Customer Customer { get; set; }

		public IList<CartItem> Items{ get; set; }
	}
}
