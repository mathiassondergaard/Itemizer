using Itemizer.Domain.Entities;
using Itemizer.Domain.Entities.ProductAggregate;

namespace Itemizer.Domain.Services;
public interface IProductVariantService
{
    void ValidateVariantProperties(CategoryId categoryId, IReadOnlyCollection<ProductProperty> propertyValues);
}