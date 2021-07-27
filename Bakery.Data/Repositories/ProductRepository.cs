using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Repositories
{
	internal class ProductRepository : BaseRepository<Product>, IProductRepository
	{
		public ProductRepository(BakeryContext context) :  base(context)
		{

		}
	}
}
