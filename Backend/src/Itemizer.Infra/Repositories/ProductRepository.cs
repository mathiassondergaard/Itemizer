using Itemizer.Domain.Entities;
using Itemizer.Domain.Repositories;
using Itemizer.Infrastructure.Database;

namespace Itemizer.Infra.Repositories;
public class ProductRepository(AppDbContext context) : Repository<Product, ProductId>(context), IProductRepository
{
}
