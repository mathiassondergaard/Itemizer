using Itemizer.Domain;
using Itemizer.Domain.Repositories;
using Itemizer.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.Storage;

namespace Itemizer.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private bool _disposed;
    private IDbContextTransaction? _transaction;

    private readonly AppDbContext _dbContext;

    // Maybe inject these via. extension?S
    public ICategoryRepository CategoryRepository => throw new NotImplementedException();

    public IProductRepository ProductRepository => throw new NotImplementedException();

    public void BeginTransaction() => _transaction = _dbContext.Database.BeginTransaction();

    public int SaveChanges() => _dbContext.SaveChanges();

    public async Task<int> SaveChangesAsync(CancellationToken token) => await _dbContext.SaveChangesAsync(token);

    public void CommitChanges()
    {
        try
        {
            if (_transaction == null) throw new NullReferenceException();

            _dbContext.SaveChanges();
            _transaction.Commit();
        }
        finally
        {
            _transaction?.Dispose();
            _transaction = null;
        }
    }

    public async Task CommitChangesAsync(CancellationToken token)
    {
        try
        {
            if (_transaction == null) throw new NullReferenceException();

            await _dbContext.SaveChangesAsync(token);
            _transaction.Commit();

        }
        finally
        {
            _transaction?.Dispose();
            _transaction = null;
        }
    }

    public async Task ExecuteTransactionAsync(Action action, CancellationToken token)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync(token);
        
        try
        {
            action();
            await _dbContext.SaveChangesAsync(token);
            await transaction.CommitAsync(token);
        } 
        catch (Exception)
        {
            await transaction.RollbackAsync(token);
            // maybe throw custom transactionCouldntBeExecuted exception
        }
        finally
        {
            transaction.Dispose();
        }
    }

    public async Task ExecuteTransactionAsync(Func<Task> action, CancellationToken token)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync(token);

        try
        {
            await action();
            await _dbContext.SaveChangesAsync(token);
            await transaction.CommitAsync(token);
        }
        catch (Exception)
        {
            await transaction.RollbackAsync(token);
            // maybe throw custom transactionCouldntBeExecuted exception
        }
        finally
        {
            transaction.Dispose();
        }
    }

    public void Rollback()
    {
        if (_transaction == null) throw new NullReferenceException();

        _transaction.Rollback();
        _transaction?.Dispose();
        _transaction= null;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _transaction?.Dispose();
                _dbContext.Dispose();
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