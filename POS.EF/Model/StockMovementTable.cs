using System;
using System.Collections.Generic;

#nullable disable

namespace POS.EF.Model
{
    public partial class StockMovementTable
    {
        public int StockMovementId { get; set; }
        public DateTime StockMovemntDate { get; set; }
        public string ProductId { get; set; }
        public int StockQty { get; set; }
        public int? StockOutQty { get; set; }
        public string Details { get; set; }
    }
}
