using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bakery.Data.Interfaces
{
	public interface IBaseRepository<T>
	{
		Task<T> Add(T item);

		Task<T> Get(int itemId);

		Task<List<T>> GetAll();

		Task<T> Update(T item);

		Task Delete(int itemId);
	}
}
