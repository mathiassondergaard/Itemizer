using Itemizer.Domain.Entities;
using Itemizer.Domain.Repositories;
using Itemizer.Infrastructure.Database;

namespace Itemizer.Infra.Repositories;
public class BrandRepository(AppDbContext context) : Repository<Brand, BrandId>(context), IBrandRepository
{
}
