using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Inventory : IEntity<InventoryId>
{
    public InventoryId Id { get; private set; }
    public Product Product { get; private set; } = null!;

    public int Stock { get; private set; }

    public int MinimumStock { get; private set; }

    public int MaximumStock { get; private set; }

    public int ReorderPoint {  get; private set; }
}

public readonly record struct InventoryId(Guid Value);