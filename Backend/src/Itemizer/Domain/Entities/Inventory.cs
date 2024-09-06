namespace Itemizer.Domain.Entities;

public class Inventory : Entity
{
    public int Quantity { get; set; }
    public int MinimumQuantity { get; set; }
    public int MaximumQuantity { get; set; }
    public int ReorderPoint {  get; set; }
    public Item Item { get; set; }  
}
