using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Category : IEntity<CategoryId>
{
    public CategoryId Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public ICollection<Product> AffiliatedProducts { get; } = new List<Product>();

    public ICollection<Property> Properties { get; } = new List<Property>();
}

public readonly record struct CategoryId(Guid Value);