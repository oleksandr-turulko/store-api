using Microsoft.EntityFrameworkCore;
using StoreApp.Application.Repository;
using StoreApp.Core.Common;
using StoreApp.Persistence.Context;

namespace StoreApp.Persistence.Repository;

public abstract class BaseRepository<T>:IBaseRepository<T> where T : BaseEntity
{
    private readonly StoreAppDbContext _context;

    protected BaseRepository(StoreAppDbContext context)
    {
        _context = context;
    }
    public void Create(T entity)
    {
        _context.Add(entity);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
    }

    public Task<T> Get(Guid id, CancellationToken cancellationToken)
    {
        return _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return _context.Set<T>().ToListAsync(cancellationToken);
    }
}