using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class ProductField : Entity
{
    public string Value { get; set; }

    public TypeField TypeField { get; set; } = null!;

    public Product Product { get; set; } = null!;
}