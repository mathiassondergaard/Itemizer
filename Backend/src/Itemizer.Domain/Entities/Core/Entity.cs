namespace Itemizer.Domain.Entities.Core;
public abstract class Entity<TId>
{
    public TId Id { get; set; } = default!;
}