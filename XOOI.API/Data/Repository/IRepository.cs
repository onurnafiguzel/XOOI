using System.Linq.Expressions;

namespace XOOI.API.Data.Repository;

public interface IRepository<TEntity> where TEntity : class
{
	Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
	Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate);
	Task<IList<TEntity>> GetAllAsync();
	Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate);
	Task AddAsync(TEntity entity);
	Task UpdateAsync(TEntity entity);
	Task DeleteAsync(TEntity entity);
}
