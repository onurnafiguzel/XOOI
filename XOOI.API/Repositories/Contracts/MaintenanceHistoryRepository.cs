using Microsoft.EntityFrameworkCore;
using XOOI.API.Entities;
using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Repositories.Contracts;

public class MaintenanceHistoryRepository : Repository<MaintenanceHistory>, IMaintenanceHistoryRepository
{
    public MaintenanceHistoryRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
