using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Repositories
{
	internal class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
	{
		public ProductCategoryRepository(BakeryContext context) : base(context)
		{

		}
	}
}