using Itemizer.Domain.Entities.Interfaces;
using Itemizer.Domain.Enums;

namespace Itemizer.Domain.Entities;
public class Transaction : IEntity<TransactionId>
{
    public TransactionId Id { get; private set; }

    public Inventory Inventory { get; private set; } = null!;

    public int Quantity_changed { get; private set; }

    public string Operator { get; private set; } = string.Empty;

    public TransactionType TransactionType { get; private set; }
}

public readonly record struct TransactionId(Guid Value);
