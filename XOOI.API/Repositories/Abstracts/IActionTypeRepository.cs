using System.Linq.Expressions;
using XOOI.API.Entities;

namespace XOOI.API.Repositories.Abstracts;

public interface IActionTypeRepository : IRepository
{
    Task<ActionType> GetAsync(Expression<Func<ActionType, bool>> predicate);
    Task<IList<ActionType>> GetListAsync(Expression<Func<ActionType, bool>> predicate);
    Task<IList<ActionType>> GetAllAsync();
    Task<bool> IsExistAsync(Expression<Func<ActionType, bool>> predicate);
    Task AddAsync(ActionType entity);
    Task UpdateAsync(ActionType entity);
    Task DeleteAsync(ActionType entity);
}
