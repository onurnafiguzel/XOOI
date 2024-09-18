using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Data.UnitOfWork;

public interface IUnitOfWork
{
    T GetRepository<T>() where T : IRepository;
    int Commit();
    Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
}
