using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class TypeField : IEntity<TypeFieldId>
{
    public TypeFieldId Id { get; private set; }

    public string Name { get; private set; }

    public Type Type { get; private set; } = null!;
}

public readonly record struct TypeFieldId(Guid Value);