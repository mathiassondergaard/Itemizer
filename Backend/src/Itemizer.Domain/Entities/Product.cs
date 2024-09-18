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

    public Type Type { get; private set; } = null!;

    public ICollection<Inventory> Inventories { get; } = new List<Inventory>();

    public ICollection<ProductField> Fields { get; } = new List<ProductField>();
}

public readonly record struct ProductId(Guid Value);