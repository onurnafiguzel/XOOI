using Microsoft.EntityFrameworkCore;
using XOOI.API.Entities;
using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Repositories.Contracts;

public class PictureGroupRepository : Repository<PictureGroup>, IPictureGroupRepository
{
    public PictureGroupRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
