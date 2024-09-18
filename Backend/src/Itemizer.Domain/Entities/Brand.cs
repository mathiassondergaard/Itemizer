using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Brand : Entity
{
    public string Name { get; set; }

    public ICollection<Product> Products { get; } = new List<Product>();
}