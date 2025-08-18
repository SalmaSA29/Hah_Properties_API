using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItphysicalHistory
    {
        public int HistoryId { get; set; }
        public int ProjectId { get; set; }
        public int? TypesId { get; set; }
        public string BarCode { get; set; }
        public string UserHrcode { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
