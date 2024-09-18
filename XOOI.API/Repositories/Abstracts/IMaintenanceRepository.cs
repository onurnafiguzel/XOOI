using System.Linq.Expressions;
using XOOI.API.Entities;

namespace XOOI.API.Repositories.Abstracts;

public interface IMaintenanceRepository : IRepository
{
    Task<Maintenance> GetAsync(Expression<Func<Maintenance, bool>> predicate);
    Task<IList<Maintenance>> GetListAsync(Expression<Func<Maintenance, bool>> predicate);
    Task<IList<Maintenance>> GetAllAsync();
    Task<bool> IsExistAsync(Expression<Func<Maintenance, bool>> predicate);
    Task AddAsync(Maintenance entity);
    Task UpdateAsync(Maintenance entity);
    Task DeleteAsync(Maintenance entity);
}
