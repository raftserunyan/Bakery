using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;

namespace Bakery.Data.Repositories
{
	internal class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		protected readonly BakeryContext _context;

		public BaseRepository(BakeryContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}

			_context = context;
		}

		public virtual async Task<T> Add(T item)
		{
			if (item == null)
				throw new ArgumentNullException(nameof(item));

			await _context.AddAsync(item);
			await _context.SaveChangesAsync();

			return item;
		}

		public virtual async Task<T> Get(int itemId)
		{
			return await _context.Set<T>().FindAsync(itemId);
		}

		public virtual async Task<List<T>> GetAll()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public virtual async Task<T> Update(T item)
		{
			_context.Entry(item).State = EntityState.Modified;

			await _context.SaveChangesAsync();

			return item;
		}

		public virtual async Task Delete(int itemId)
		{
			var item = await _context.Set<T>().FindAsync(itemId);

			if (item == null)
				throw new ArgumentNullException(nameof(itemId), "Given entity doesn't exist");

			_context.Set<T>().Remove(item);

			await _context.SaveChangesAsync();
		}
	}
}
