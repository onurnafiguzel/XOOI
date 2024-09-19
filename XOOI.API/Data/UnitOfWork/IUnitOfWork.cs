using XOOI.API.Data.Repository;

namespace XOOI.API.Data.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
	public IRepository<T> GetRepository<T>() where T : class;
	int Commit();
    Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
}
