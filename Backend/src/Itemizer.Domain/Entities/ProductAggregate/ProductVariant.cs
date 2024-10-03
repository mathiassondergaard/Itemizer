using Itemizer.Domain.Entities.Core;

namespace Itemizer.Domain.Entities.ProductAggregate;
public class ProductVariant : Entity<ProductVariantId>
{
    public ProductVariantId ProductVariantId { get; private set; }
    
    public string Name { get; private set; }

    public SKU SKU { get; private set; }

    // Utilizing private list for aggregate encapsulation - can't be modified outside of aggregate root
    private List<ProductProperty> _properties;

    public IReadOnlyCollection<ProductProperty> Properties => _properties.AsReadOnly();

    public ProductVariant(ProductVariantId productVariantId, string name, SKU sku, List<ProductProperty> properties)
    {
        ProductVariantId = productVariantId;
        Name = name;
        SKU = sku;
        _properties = properties ?? new List<ProductProperty>();
    }

    public void AddProperty(ProductProperty property)
    {
        var existingProperty = _properties.SingleOrDefault(p => p.Name.Equals(property.Name, StringComparison.OrdinalIgnoreCase));

        if (existingProperty != null)
        {
            _properties.Remove(existingProperty);
        }

        _properties.Add(property);
    }

    private void ValidateProperty(Category category)
    {
        // loop properties of category
        // if property is not found or null, throw property exception
        // additional validation on type? (maybe)
    }
}
