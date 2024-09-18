using XOOI.API.Repositories.Abstracts;

namespace XOOI.API.Data.UnitOfWork;

public class UnitOfWork<TContenxt> : IUnitOfWork
{
    private readonly IServiceProvider _serviceProvider;
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context, IServiceProvider serviceProvider)
    {
        _context = context;
        _serviceProvider = serviceProvider;
    }

    public int Commit()
    {
        return _context.SaveChanges();
    }

    public Task<int> CommitAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync();
    }

    public T GetRepository<T>() where T : IRepository
    {
        return _serviceProvider.GetService<T>();
    }
}
