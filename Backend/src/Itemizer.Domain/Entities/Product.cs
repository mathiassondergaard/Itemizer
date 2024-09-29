using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Product : IEntity<ProductId>
{
    public ProductId Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public Category Category { get; private set; } = null!;

    public ICollection<ProductVariant> Variants { get; } = new List<ProductVariant>();

}

public readonly record struct ProductId(Guid Value);