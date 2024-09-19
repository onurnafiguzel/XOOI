using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

namespace XOOI.API.Data.Repository;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
	private readonly DbContext dbContext;

	public Repository(DbContext dbContext)
	{
		this.dbContext = dbContext;
	}

	public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
	{
		return await dbContext.Set<TEntity>().SingleOrDefaultAsync(predicate);
	}

	public virtual async Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
	{
		return await dbContext.Set<TEntity>().Where(predicate).ToListAsync();
	}

	public virtual async Task<IList<TEntity>> GetAllAsync()
	{
		return await dbContext.Set<TEntity>().ToListAsync();
	}

	public virtual Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate)
	{
		return dbContext.Set<TEntity>().AnyAsync(predicate);
	}

	public virtual async Task AddAsync(TEntity entity)
	{
		if (entity == null) throw new ArgumentNullException($"entity {nameof(TEntity)} is null");

		await dbContext.Set<TEntity>().AddAsync(entity);
	}

	public virtual Task UpdateAsync(TEntity entity)
	{
		dbContext.Set<TEntity>().Update(entity);
		return Task.CompletedTask;
	}

	public virtual Task DeleteAsync(TEntity entity)
	{
		dbContext.Set<TEntity>().Remove(entity);
		return Task.CompletedTask;
	}
}
