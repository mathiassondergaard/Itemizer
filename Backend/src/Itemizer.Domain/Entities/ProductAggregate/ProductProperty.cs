using Itemizer.Domain.Entities.Core;

namespace Itemizer.Domain.Entities.ProductAggregate;
public class ProductProperty : ValueObject
{
    public string Name { get; }

    public string Value { get; }

    public ProductProperty(string name, string value)
    {
        Name = name;
        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return Value;
    }
}
