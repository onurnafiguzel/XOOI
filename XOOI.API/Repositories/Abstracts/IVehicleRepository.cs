using System.Linq.Expressions;
using XOOI.API.Entities;

namespace XOOI.API.Repositories.Abstracts;

public interface IVehicleRepository : IRepository
{
    Task<Vehicle> GetAsync(Expression<Func<Vehicle, bool>> predicate);
    Task<IList<Vehicle>> GetListAsync(Expression<Func<Vehicle, bool>> predicate);
    Task<IList<Vehicle>> GetAllAsync();
    Task<bool> IsExistAsync(Expression<Func<Vehicle, bool>> predicate);
    Task AddAsync(Vehicle entity);
    Task UpdateAsync(Vehicle entity);
    Task DeleteAsync(Vehicle entity);
}
