using System.Linq.Expressions;
using XOOI.API.Entities;

namespace XOOI.API.Repositories.Abstracts;

public interface IMaintenanceHistoryRepository : IRepository
{
    Task<MaintenanceHistory> GetAsync(Expression<Func<MaintenanceHistory, bool>> predicate);
    Task<IList<MaintenanceHistory>> GetListAsync(Expression<Func<MaintenanceHistory, bool>> predicate);
    Task<IList<MaintenanceHistory>> GetAllAsync();
    Task<bool> IsExistAsync(Expression<Func<MaintenanceHistory, bool>> predicate);
    Task AddAsync(MaintenanceHistory entity);
    Task UpdateAsync(MaintenanceHistory entity);
    Task DeleteAsync(MaintenanceHistory entity);
}
