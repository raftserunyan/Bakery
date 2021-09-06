using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Repositories
{
	internal class OrderRepository : BaseRepository<Order>, IOrderRepository
	{
		public OrderRepository(BakeryContext context) : base(context)
		{

		}
	}
}
