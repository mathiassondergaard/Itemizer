using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Stock : IEntity<StockId>
{
    public StockId Id { get; private set; }
    public Product Product { get; private set; } = null!;

    public int Quantity { get; private set; }

    public int MinimumQuantity { get; private set; }

    public int MaximumQuantity { get; private set; }

    public int ReorderPoint {  get; private set; }
}

public readonly record struct StockId(Guid Value);