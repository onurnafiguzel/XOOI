using Microsoft.EntityFrameworkCore;
using XOOI.API.Entities;
using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Repositories.Contracts;

public class ActionTypeRepository : Repository<ActionType>, IActionTypeRepository
{
    public ActionTypeRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
