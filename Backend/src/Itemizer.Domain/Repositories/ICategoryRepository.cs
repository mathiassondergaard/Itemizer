using Itemizer.Domain.Entities;

namespace Itemizer.Domain.Repositories;
public interface ICategoryRepository : IRepository<Category, CategoryId>
{
    // Manages Category and CategoryField
}
