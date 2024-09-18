using Itemizer.Domain.Entities.Interfaces;
using System.Linq.Expressions;

namespace Itemizer.Domain.Repositories;

public interface IRepository<TEntity, TId> where TEntity : IEntity<TId>
{
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    void Delete(TEntity entity);
    Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> GetByIdAsync(TId id, IEnumerable<string> includedEntities);

    /// <param name="predicates">Condition to satisfy on query</param>
    /// <param name="includedEntities">Child entities to include</param>
    Task<IEnumerable<TEntity>> GetAllAsync(IEnumerable<Expression<Func<TEntity, bool>>> predicates, IEnumerable<string> includedEntities);
    Task<IEnumerable<TEntity>> GetAsync(int rowsToSkip, int rowsToGet, IEnumerable<Expression<Func<TEntity, bool>>> predicates, IEnumerable<string> includedEntities);

    // Maybe add a count method too
}