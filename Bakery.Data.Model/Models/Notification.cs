using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Data.Model.Models
{
	public class Notification
	{ 
		public int Id { get; set; }
		public string Text { get; set; }
		public bool IsRead { get; set; }
		public DateTime DateCreated { get; set; }
		public string Link { get; set; }

		public int CustomerId { get; set; }
		[ForeignKey(nameof(CustomerId))]
		public Customer Customer { get; set; }
	}
}
