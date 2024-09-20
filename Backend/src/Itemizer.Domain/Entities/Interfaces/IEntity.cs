namespace Itemizer.Domain.Entities.Interfaces;
public interface IEntity<TId>
{
    TId Id { get; }
}