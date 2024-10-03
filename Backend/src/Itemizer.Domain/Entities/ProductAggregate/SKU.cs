using Itemizer.Domain.Entities.Core;

namespace Itemizer.Domain.Entities.ProductAggregate;
public class SKU : ValueObject
{
    public string Value { get; }

    public SKU(string value)
    {
        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}
