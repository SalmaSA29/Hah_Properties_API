using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstNewItemForCashD
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int CashItemId { get; set; }
        public double? Amount { get; set; }
        public string Comments { get; set; }
    }
}
