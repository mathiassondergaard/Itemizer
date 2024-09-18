using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Type : Entity
{
    public string Name { get; set; }

    public ICollection<Product> AffiliatedProducts { get; set; }

    public ICollection<TypeField> AllowedFields { get; } = new List<TypeField>();
}