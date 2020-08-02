using System;
using System.Collections.Generic;

namespace ProductApp.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int? ProductQuantity { get; set; }
        public DateTime? CreatedDatetime { get; set; }
    }
}
