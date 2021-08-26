using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Bakery.Data.Interfaces
{
	public interface IBaseRepository<TEntity>
	{
		Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
		Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

		Task<IEnumerable<TEntity>> GetAllAsync();
		Task<IEnumerable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includeExpressions);

		Task<IEnumerable<TEntity>> GetAllTrackingAsync();
		Task<IEnumerable<TEntity>> GetAllTrackingAsync(params Expression<Func<TEntity, object>>[] includeExpressions);

		Task<IEnumerable<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> whereExpression);
		Task<IEnumerable<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> whereExpression, params Expression<Func<TEntity, object>>[] includeExpressions);
		Task<IEnumerable<TResult>> GetWhereSelectAsync<TResult>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TResult>> select);

		IQueryable<TResult> GetQueryableWhereSelect<TResult>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TResult>> select, params Expression<Func<TEntity, object>>[] includeProperties);
		IQueryable<TResult> GetQueryableSelectAsync<TResult>(Expression<Func<TEntity, TResult>> select, params Expression<Func<TEntity, object>>[] includeProperties);
		IQueryable<TResult> GetQueryableProjection<TResult>(Expression<Func<TEntity, TResult>> projection);

		Task<TEntity> AddAsync(TEntity entity);
		Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);

		TEntity Update(TEntity entity);
		Task<TEntity> UpdateAsync(TEntity entity);
		IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entities);

		void Remove(TEntity entity);
		void RemoveRange(IEnumerable<TEntity> entities);


		Task<int> CountAllAsync();
		Task<int> CountWhereAsync(Expression<Func<TEntity, bool>> predicate);

		Task<bool> ExistsWhereAsync(Expression<Func<TEntity, bool>> predicate);
		
		Task<bool> CommitAsync();
	}
}
