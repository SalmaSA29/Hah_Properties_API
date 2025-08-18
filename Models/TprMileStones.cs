using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprMileStones
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int RecordId { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DescriptionDate { get; set; }
        public DateTime? Date2 { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
