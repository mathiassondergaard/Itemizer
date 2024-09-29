using Itemizer.Domain.Repositories;
using Itemizer.Domain.Entities.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Itemizer.Infra.Helpers;
using Itemizer.Infrastructure.Database;

namespace Itemizer.Infra.Repositories;
public class Repository<TEntity, TId>(AppDbContext dbContext) : IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
{
    protected readonly DbSet<TEntity> _dbSet = dbContext.Set<TEntity>();

    public async Task AddAsync(TEntity entity) => await _dbSet.AddAsync(entity);

    public void Delete(TEntity entity) => _dbSet.Remove(entity);

    public async Task DeleteAsync(TEntity entity) => await Task.Run(() => { Delete(entity); });
    public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate) => await _dbSet.AnyAsync(predicate);

    public async Task<IEnumerable<TEntity>> GetAllAsync(IEnumerable<Expression<Func<TEntity, bool>>> predicates, IEnumerable<string> includedEntities) => await _dbSet
        .WhereAny(predicates)
        .IncludeEntities(includedEntities)
        .AsNoTracking()
        .ToListAsync();

    public async Task<IEnumerable<TEntity>> GetPagedAsync(int rowsToSkip, int rowsToGet, IEnumerable<Expression<Func<TEntity, bool>>> predicates, IEnumerable<string> includedEntities) => await _dbSet
        .WhereAny(predicates)
        .Skip(rowsToSkip)
        .Take(rowsToGet)
        .IncludeEntities(includedEntities)
        .AsNoTracking()
        .ToListAsync();

    public async Task<TEntity?> GetByIdAsync(TId id, IEnumerable<string> includedEntities) => await _dbSet.IncludeEntities(includedEntities).FirstOrDefaultAsync(e => e.Id.Equals(id));
   
    public async Task UpdateAsync(TEntity entity) => await Task.Run(() => _dbSet.Update(entity));

    public async Task<int> CountAsync(IEnumerable<Expression<Func<TEntity, bool>>> predicates) => await _dbSet.WhereAny(predicates).CountAsync();

    public Task<TEntity?> GetByPredicate(Expression<Func<TEntity, bool>> predicates, IEnumerable<string> includedEntities) => _dbSet.IncludeEntities(includedEntities).FirstOrDefaultAsync(predicates);
}