using Itemizer.Domain.Entities;
using System;

namespace Itemizer.Domain.DTOs
{
    public class InventoryDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }

        public int ReorderPoint { get; set; }

        public ItemDTO Item { get; set; }
    }
}
