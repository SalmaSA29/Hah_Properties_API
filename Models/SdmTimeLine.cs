using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SdmTimeLine
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? TaskTypeId { get; set; }
        public int? TaskId { get; set; }
        public string Description { get; set; }
        public DateTime? FormDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string UserHrCode { get; set; }
        public int? Status { get; set; }
        public DateTime? ExpectedDate { get; set; }
    }
}
