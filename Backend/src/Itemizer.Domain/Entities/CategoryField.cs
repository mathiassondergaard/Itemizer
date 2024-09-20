using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class CategoryField : IEntity<CategoryFieldId>
{
    public CategoryFieldId Id { get; private set; }

    public string Name { get; private set; }

    public Category Type { get; private set; } = null!;
}

public readonly record struct CategoryFieldId(Guid Value);