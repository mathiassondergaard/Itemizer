using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Type : IEntity<TypeId>
{
    public TypeId Id { get; private set; }

    public string Name { get; private set; }

    public ICollection<Product> AffiliatedProducts { get; } = new List<Product>();

    public ICollection<TypeField> AllowedFields { get; } = new List<TypeField>();
}

public readonly record struct TypeId(Guid Value);