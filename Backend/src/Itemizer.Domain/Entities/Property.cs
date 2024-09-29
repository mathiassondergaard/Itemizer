using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Property : IEntity<PropertyId>
{
    public PropertyId Id { get; private set; }
    
    public string Name { get; private set; } = string.Empty;

    public string Type { get; private set; } = string.Empty;

    public ICollection<Category> AffiliatedCategories { get; } = new List<Category>();
}

public readonly record struct PropertyId(Guid Value);
