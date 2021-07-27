using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Repositories
{
	internal class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
	{
		public CustomerRepository(BakeryContext context) : base(context)
		{

		}
	}
}
