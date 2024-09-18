using System.Linq.Expressions;
using XOOI.API.Entities;

namespace XOOI.API.Repositories.Abstracts;

public interface IVehicleTypeTypeRepository : IRepository
{
    Task<VehicleType> GetAsync(Expression<Func<VehicleType, bool>> predicate);
    Task<IList<VehicleType>> GetListAsync(Expression<Func<VehicleType, bool>> predicate);
    Task<IList<VehicleType>> GetAllAsync();
    Task<bool> IsExistAsync(Expression<Func<VehicleType, bool>> predicate);
    Task AddAsync(VehicleType entity);
    Task UpdateAsync(VehicleType entity);
    Task DeleteAsync(VehicleType entity);
}
