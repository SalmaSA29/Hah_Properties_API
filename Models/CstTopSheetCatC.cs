using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTopSheetCatC
    {
        public int TopSheetCatCId { get; set; }
        public string TopSheetCatCName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string CostId { get; set; }
    }
}
