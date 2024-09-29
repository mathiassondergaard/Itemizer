using Itemizer.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itemizer.Domain.Entities;
public class ProductVariant : IEntity<ProductVariantId>
{
    public ProductVariantId Id { get; private set; }

    public int ReorderQuantity { get; private set; }

    public string SKU { get; private set; } = string.Empty;

    public string Barcode { get; private set; } = string.Empty;

    public Inventory Inventory { get; private set; } = null!;

    public Product Product { get; private set; } = null!;
}

public readonly record struct ProductVariantId(Guid Value);