using Itemizer.Domain.Entities.Interfaces;
using System.Linq.Expressions;

namespace Itemizer.Domain.Repositories;

public interface IRepository<T> where T : Entity
{
    Task AddAsync(T t);
    Task UpdateAsync(T t);
    Task DeleteAsync(T t);
    void Delete(T t);
    Task<bool> ExistAsync(Expression<Func<T, bool>> predicate);
    Task<T> GetByIdAsync(int id, IEnumerable<string> includedEntities);

    /// <param name="predicates">Condition to satisfy on query</param>
    /// <param name="includedEntities">Child entities to include</param>
    Task<IEnumerable<T>> GetAllAsync(IEnumerable<Expression<Func<T, bool>>> predicates, IEnumerable<string> includedEntities);
    Task<IEnumerable<T>> GetAsync(int rowsToSkip, int rowsToGet, IEnumerable<Expression<Func<T, bool>>> predicates, IEnumerable<string> includedEntities);

    // Maybe add a count method too
}