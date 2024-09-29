using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Inventory : IEntity<StockId>
{
    public StockId Id { get; private set; }
    public Product Product { get; private set; } = null!;

    public int Quantity { get; private set; }

    public int MinimumQuantity { get; private set; }

    public int MaximumQuantity { get; private set; }

    public int ReorderPoint { get; private set; }

    public ICollection<Transaction> Transactions { get; } = new List<Transaction>();
}

public readonly record struct StockId(Guid Value);