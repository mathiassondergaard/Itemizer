using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itemizer.Domain.Entities;
public class ProductVariantProperty
{
    public ProductVariant ProductVariant { get; private set; } = null!;

    public Property Property { get; private set; } = null!;

    public string Value { get; private set; } = string.Empty;
}
