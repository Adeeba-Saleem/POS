using System;
using System.Collections.Generic;

#nullable disable

namespace POS.EF.Model
{
    public partial class ProductsDetailTable
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Barcode { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Discount { get; set; }
        public bool? ExpiryStatus { get; set; }
        public string ValuationMethod { get; set; }
        public bool? ActiveStatus { get; set; }
    }
}
