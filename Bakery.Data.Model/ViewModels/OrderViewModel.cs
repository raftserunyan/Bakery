using System.Collections.Generic;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Model.ViewModels
{
	public class OrderViewModel
	{
		public int Id { get; set; }

		public Dictionary<int, int> OrdersList { get; set; }

		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
	}
}
