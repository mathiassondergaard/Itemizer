using System;

namespace Itemizer.Domain.Entities
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public string SKU { get; set; }

        public string BarCode { get; set; }

        public int ReorderQuantity { get; set; }

    }
}
