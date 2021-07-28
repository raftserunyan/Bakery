using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Repositories
{
	internal class CartItemRepository : BaseRepository<CartItem>, ICartItemRepository
	{
		public CartItemRepository(BakeryContext context) : base(context)
		{

		}
	}
}
