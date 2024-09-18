using System.Linq.Expressions;
using XOOI.API.Entities;

namespace XOOI.API.Repositories.Abstracts;

public interface IPictureGroupRepository : IRepository
{
    Task<PictureGroup> GetAsync(Expression<Func<PictureGroup, bool>> predicate);
    Task<IList<PictureGroup>> GetListAsync(Expression<Func<PictureGroup, bool>> predicate);
    Task<IList<PictureGroup>> GetAllAsync();
    Task<bool> IsExistAsync(Expression<Func<PictureGroup, bool>> predicate);
    Task AddAsync(PictureGroup entity);
    Task UpdateAsync(PictureGroup entity);
    Task DeleteAsync(PictureGroup entity);
}
