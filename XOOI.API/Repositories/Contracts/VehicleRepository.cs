using Microsoft.EntityFrameworkCore;
using XOOI.API.Entities;
using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Repositories.Contracts;

public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
{
    public VehicleRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
