using Microsoft.EntityFrameworkCore;
using XOOI.API.Entities;
using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Repositories.Contracts;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
