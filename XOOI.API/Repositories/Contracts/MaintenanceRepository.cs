using Microsoft.EntityFrameworkCore;
using XOOI.API.Entities;
using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Repositories.Contracts;

public class MaintenanceRepository : Repository<Maintenance>, IMaintenanceRepository
{
    public MaintenanceRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
