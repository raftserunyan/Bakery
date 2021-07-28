using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Repositories
{
	internal class OrderStatusRepository : BaseRepository<OrderStatus>, IOrderStatusRepository
	{
		public OrderStatusRepository(BakeryContext context) : base(context)
		{

		}
	}
}
