namespace Itemizer.Domain.DTOs;

public class ItemDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SKU { get; set; }
    public string BarCode { get; set; }
    public int ReorderQuantity { get; set; }
}