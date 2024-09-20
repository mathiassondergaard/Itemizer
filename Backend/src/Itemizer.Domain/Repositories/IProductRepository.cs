using Itemizer.Domain.Entities;

namespace Itemizer.Domain.Repositories;
public interface IProductRepository : IRepository<Product, ProductId>
{
    // Manages Product, ProductField, Stock
}
