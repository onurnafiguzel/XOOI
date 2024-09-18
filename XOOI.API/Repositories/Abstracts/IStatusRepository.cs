using System.Linq.Expressions;
using XOOI.API.Entities;

namespace XOOI.API.Repositories.Abstracts;

public interface IStatusRepository : IRepository
{
    Task<Status> GetAsync(Expression<Func<Status, bool>> predicate);
    Task<IList<Status>> GetListAsync(Expression<Func<Status, bool>> predicate);
    Task<IList<Status>> GetAllAsync();
    Task<bool> IsExistAsync(Expression<Func<Status, bool>> predicate);
    Task AddAsync(Status entity);
    Task UpdateAsync(Status entity);
    Task DeleteAsync(Status entity);
}
