using Itemizer.Domain.Entities.Core;
using Itemizer.Domain.Services;

namespace Itemizer.Domain.Entities.ProductAggregate;
public class Product : Entity<ProductId>, IAggregateRoot
{
    public ProductId ProductId { get; private set; }
    
    public string Name { get; private set; }

    public CategoryId Category { get; private set; }

    // Utilizing private list for aggregate encapsulation - can't be modified outside of aggregate root
    private List<ProductVariant> _variants;

    public IReadOnlyCollection<ProductVariant> Variants => _variants.AsReadOnly();

    public Product(string name, CategoryId categoryId)
    {
        Id = new ProductId(new Guid());
        Name = name;
        Category = categoryId;
        _variants = new List<ProductVariant>();
    }
    public void AddVariant(ProductVariant variant, IProductVariantService _productVariantService)
    {
        // Adding of a variant is validated by a domain service
        _productVariantService.ValidateVariantProperties(Category, variant.Properties);
        _variants.Add(variant);
    }

    public void RemoveVariant(ProductVariant variant) 
    {
        _variants.Remove(variant);
    }
}
