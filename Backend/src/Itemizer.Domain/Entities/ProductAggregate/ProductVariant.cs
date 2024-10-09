using Itemizer.Domain.Entities.Core;
using Itemizer.Domain.Exceptions;
using Itemizer.Domain.Services;

namespace Itemizer.Domain.Entities.ProductAggregate;
public class ProductVariant : Entity<ProductVariantId>
{
    public ProductVariantId ProductVariantId { get; private set; }
    
    public string Name { get; private set; }

    public SKU SKU { get; private set; }

    // Utilizing private list for aggregate encapsulation - can't be modified outside of aggregate root
    private List<ProductProperty> _properties;

    public IReadOnlyCollection<ProductProperty> Properties => _properties.AsReadOnly();

    public ProductVariant(Product product, string name, SKU sku, List<ProductProperty> properties)
    {
        ProductVariantId = new ProductVariantId(new Guid());
        Name = name;
        SKU = sku;
        _properties = properties ?? new List<ProductProperty>();
    }

    public void AddOrUpdateProperty(ProductProperty property, IProductVariantService _productVariantService)
    {
        var existingProperty = _properties.SingleOrDefault(p => p.Name.Equals(property.Name, StringComparison.OrdinalIgnoreCase));

        if (existingProperty != null)
        {
            _properties.Remove(existingProperty);
        }

        _properties.Add(property);
    }

    public void RemoveProperty(ProductProperty property)
    {
        var existingProperty = _properties.SingleOrDefault(p => p.Name.Equals(property.Name, StringComparison.OrdinalIgnoreCase));

        if (existingProperty == null)
        {
            throw new DomainException("Property" + property.Name + "does not exist on variant!");
        }

        _properties.Remove(existingProperty);
    }
}
