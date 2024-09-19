using XOOI.API.Data.Repository;

namespace XOOI.API.Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{   
    private readonly AppDbContext _context;
	private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

	public UnitOfWork(AppDbContext context)
    {
        _context = context;      
    }

    public int Commit()
    {
        return _context.SaveChanges();
    }

    public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync();
    }

	public void Dispose()
	{
        _context?.Dispose();
	}

	public IRepository<T> GetRepository<T>() where T : class
    {
        var type = typeof(T);

		if (!_repositories.ContainsKey(type))
		{
			var repositoryType = typeof(Repository<>).MakeGenericType(type);
			_repositories[type] = Activator.CreateInstance(repositoryType, _context);
		}

		return (IRepository<T>)_repositories[type];

	}
}
