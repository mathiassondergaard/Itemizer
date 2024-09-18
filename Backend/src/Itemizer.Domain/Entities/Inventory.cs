using Itemizer.Domain.Entities.Interfaces;

namespace Itemizer.Domain.Entities;
public class Inventory : Entity
{
    public Product Product { get; set; } = null!;

    public int Stock { get; set; }

    public int MinimumStock { get; set; }

    public int MaximumStock { get; set; }

    public int ReorderPoint {  get; set; }
}