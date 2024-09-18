using Itemizer.Domain.Repositories;

namespace Itemizer.Domain;

public interface IUnitOfWork : IDisposable
{
    //InterfaceRepositoryName IRepositoryName { get; set; }

    /// <summary>
    /// Saves changes to the database
    /// </summary>
    /// <returns>The number of changes saved or - 1 if error occurs, with appropiate error-code</returns>
    int SaveChanges();

    /// <summary>
    /// Saves changes to the data source asynchronously, with possibility of cancelling thread. 
    /// </summary>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Commits the changes to the database
    /// </summary>
    void CommitChanges();

    /// <summary>
    /// Commits the changes to the database asynchronously, with possibility of cancelling thread
    /// </summary>
    Task CommitChangesAsync(CancellationToken token);

    /// <summary>
    /// Starts a transaction that must be comitted or rolled back.
    /// </summary>
    void BeginTransaction();

    /// <summary>
    /// Executes transaction asynchronously. Used for actions like delete, update ..
    /// </summary>
    Task ExecuteTransactionAsync(Action action, CancellationToken token);

    /// <summary>
    /// Executes transaction asynchronously. Used for functions like add ..
    /// </summary>
    Task ExecuteTransactionAsync(Func<Task> action, CancellationToken token);

    /// <summary>
    /// Rolls back the transaction, for example on error.
    /// </summary>
    void Rollback();
}