using System;
using System.Collections.Generic;

#nullable disable

namespace POS.EF.Model
{
    public partial class ExpiryDetail
    {
        public int ExpiryId { get; set; }
        public string ProductId { get; set; }
        public string BatchNo { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
