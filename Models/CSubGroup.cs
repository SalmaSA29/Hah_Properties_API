using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CSubGroup
    {
        public string SubGroupId { get; set; }
        public string SubGroupName { get; set; }
        public string GroupId { get; set; }
        public DateTime? RplDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }
    }
}
