using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Repositories
{
	internal class OrderItemRepository : BaseRepository<OrderItem>, IOrderItemRepository
	{
		public OrderItemRepository(BakeryContext context) : base(context)
		{

		}
	}
}
