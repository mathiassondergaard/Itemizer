using Itemizer.Domain.Entities;
using Itemizer.Domain.Repositories;
using Itemizer.Infrastructure.Database;

namespace Itemizer.Infra.Repositories;
public class CategoryRepository(AppDbContext context) : Repository<Category, CategoryId>(context), ICategoryRepository
{
}
