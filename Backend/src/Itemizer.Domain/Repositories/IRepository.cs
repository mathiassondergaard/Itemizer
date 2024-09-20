using Itemizer.Domain.Entities.Interfaces;
using System.Linq.Expressions;

namespace Itemizer.Domain.Repositories;

public interface IRepository<TEntity, TId> where TEntity : IEntity<TId>
{
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    void Delete(TEntity entity);

    /// <param name="predicates">Condition(s) to satisfy on query</param>
    Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicates);
    Task<TEntity?> GetByIdAsync(TId id, IEnumerable<string> includedEntities);
    Task<IEnumerable<TEntity>> GetAllAsync(IEnumerable<Expression<Func<TEntity, bool>>> predicates, IEnumerable<string> includedEntities);

    /// <param name="predicates">Condition(s) to satisfy on query</param>
    /// <param name="includedEntities">Child entity(ies) to include</param>
    Task<IEnumerable<TEntity>> GetPagedAsync(int rowsToSkip, int rowsToGet, IEnumerable<Expression<Func<TEntity, bool>>> predicates, IEnumerable<string> includedEntities);

    /// <param name="includedEntities">Child entity(ies) to include</param>
    Task<int> CountAsync(IEnumerable<Expression<Func<TEntity, bool>>> predicates);

    /// <param name="predicates">Condition(s) to satisfy on query</param>
    /// <param name="includedEntities">Child entity(ies) to include</param>
    Task<TEntity?> FirstOrDefault(Expression<Func<TEntity, bool>> predicates, IEnumerable<string> includedEntities);
}