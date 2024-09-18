using Microsoft.EntityFrameworkCore;
using XOOI.API.Entities;
using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Repositories.Contracts;

public class VehicleTypeRepository : Repository<VehicleType>, IVehicleTypeTypeRepository
{
    public VehicleTypeRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
