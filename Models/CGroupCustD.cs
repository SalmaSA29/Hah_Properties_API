using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CGroupCustD
    {
        public string GroupCustSId { get; set; }
        public string GroupCustMId { get; set; }
        public string GroupCustSName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }
    }
}
