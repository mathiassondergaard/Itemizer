using Itemizer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itemizer.Infrastructure.Database.Configurations;

public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.ToTable("Inventory");

        builder.HasKey(x => x.Id);
        builder.Property(p => p.Quantity).IsRequired();
        builder.Property(p => p.MinimumQuantity).IsRequired();
        builder.Property(p => p.MaximumQuantity).IsRequired();
        builder.Property(p => p.ReorderPoint).IsRequired();
        builder.Property(p => p.Item).IsRequired();
    }
}
