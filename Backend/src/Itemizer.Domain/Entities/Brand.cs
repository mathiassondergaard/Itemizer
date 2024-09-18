using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Brand : IEntity<BrandId>
{
    public BrandId Id { get; private set; }
    public string Name { get; private set; }

    public ICollection<Product> Products { get; } = new List<Product>();
}

public readonly record struct BrandId(Guid Value);