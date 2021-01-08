using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Domain.Model
{
    public class ExpiryDetail
    {
        public int ExpiryId { get; set; }
        public string ProductId { get; set; }
        public string BatchNo { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
