using Itemizer.Domain;
using Itemizer.Domain.Repositories;

namespace Itemizer.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private bool _disposed;

    public IBrandRepository BrandRepository => throw new NotImplementedException();

    public ICategoryRepository CategoryRepository => throw new NotImplementedException();

    public IProductRepository ProductRepository => throw new NotImplementedException();

    public void BeginTransaction()
    {
        throw new NotImplementedException();
    }

    public void CommitChanges()
    {
        throw new NotImplementedException();
    }

    public Task CommitChangesAsync(CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task ExecuteTransactionAsync(Action action, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task ExecuteTransactionAsync(Func<Task> action, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public void Rollback()
    {
        throw new NotImplementedException();
    }

    public int SaveChanges()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            _disposed = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

// TWO REPOS? I READABBLE IUPDATEABLE
