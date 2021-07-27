using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Data.Model.Models
{
	public class Order
	{
		[Key]
		public int Id { get; set; }
		public OrderStatus Status { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime StatusChangedDate { get; set; }


		public int CustomerId { get; set; }

		[ForeignKey("CustomerId")]
		public Customer Customer { get; set; }

		public IList<OrderItem> OrderItems { get; set; }
	}
}
