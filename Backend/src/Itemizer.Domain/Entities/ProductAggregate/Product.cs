using Itemizer.Domain.Entities.Core;

namespace Itemizer.Domain.Entities.ProductAggregate;
public class Product : Entity<ProductId>, IAggregateRoot
{
    public ProductId ProductId { get; private set; }
    
    public string Name { get; private set; }


}
