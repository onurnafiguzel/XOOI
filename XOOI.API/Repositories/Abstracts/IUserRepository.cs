using System.Linq.Expressions;
using XOOI.API.Entities;

namespace XOOI.API.Repositories.Abstracts;

public interface IUserRepository : IRepository
{
    Task<User> GetAsync(Expression<Func<User, bool>> predicate);
    Task<IList<User>> GetListAsync(Expression<Func<User, bool>> predicate);
    Task<IList<User>> GetAllAsync();
    Task<bool> IsExistAsync(Expression<Func<User, bool>> predicate);
    Task AddAsync(User entity);
    Task UpdateAsync(User entity);
    Task DeleteAsync(User entity);
}
