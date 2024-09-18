using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Product : Entity
{
    public string Name { get; set; }

    public int ReorderQuantity { get; set; }

    public string SKU { get; set; }

    public string Barcode { get; set; }

    public Brand Brand { get; set; } = null!;

    public Type Type { get; set; } = null!;

    public ICollection<Inventory> Inventories { get; } = new List<Inventory>();

    public ICollection<ProductField> Fields { get; } = new List<ProductField>();
}