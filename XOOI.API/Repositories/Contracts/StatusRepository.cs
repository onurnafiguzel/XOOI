using Microsoft.EntityFrameworkCore;
using XOOI.API.Entities;
using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Repositories.Contracts;

public class StatusRepository : Repository<Status>, IStatusRepository
{
    public StatusRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
