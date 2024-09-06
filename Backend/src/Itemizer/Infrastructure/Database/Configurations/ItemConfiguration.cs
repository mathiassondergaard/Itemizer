using Itemizer.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Itemizer.Infrastructure.Database.Configurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Item");

        builder.HasKey(x => x.Id);
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.SKU).IsRequired();
        builder.Property(p => p.BarCode).IsRequired();
        builder.Property(p => p.ReorderQuantity).IsRequired();
    }
}
