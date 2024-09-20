using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Product : IEntity<ProductId>
{
    public ProductId Id => throw new NotImplementedException();

    public string Name { get; private set; }

    public int ReorderQuantity { get; private set; }

    public string SKU { get; private set; }

    public string Barcode { get; private set; }

    public Brand Brand { get; private set; } = null!;

    public Category Category { get; private set; } = null!;

    public Stock Stock { get; private set; } = null!;

    public ICollection<ProductField> Fields { get; } = new List<ProductField>();
}

public readonly record struct ProductId(Guid Value);