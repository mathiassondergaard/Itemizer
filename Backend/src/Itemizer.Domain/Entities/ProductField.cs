using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class ProductField : IEntity<ProductFieldId>
{
    public ProductFieldId Id { get; private set; }

    public string Value { get; private set; }

    public TypeField TypeField { get; private set; } = null!;

    public Product Product { get; private set; } = null!;
}

public readonly record struct ProductFieldId(Guid Value);