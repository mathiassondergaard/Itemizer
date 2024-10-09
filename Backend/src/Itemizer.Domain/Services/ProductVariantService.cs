using Itemizer.Domain.Repositories;
using Itemizer.Domain.Exceptions;
using Itemizer.Domain.Entities;
using Itemizer.Domain.Entities.ProductAggregate;

namespace Itemizer.Domain.Services;
public class ProductVariantService : IProductVariantService
{
    private readonly ICategoryRepository _categoryRepository;

    public ProductVariantService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public void ValidateVariantProperties(CategoryId categoryId, IReadOnlyCollection<ProductProperty> properties)
    {
        /*
        var category = _categoryRepository.GetById(categoryId);
        foreach (var property in properties)
        {
            var categoryProperty = category.Properties.FirstOrDefault(p => p.Name == property.Name);
            
            if (!categoryProperty)
            {
                throw new DomainException("Property: " + property.Name + " does not exist on category");
            }
        }
        */

    }
}