using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Data.Model.Models
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Balance { get; set; }
		public int DiscountPoints { get; set; }
		public string Email { get; set; }

		public int ShoppingCartId { get; set; }
		[ForeignKey("ShoppingCartId")]
		public ShoppingCart ShoppingCart{ get; set; }

		public IList<Notification> Notifications { get; set; }

		public IList<Order> Orders { get; set; }
	}
}
