using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CGroup
    {
        public CGroup()
        {
            CFormPermision = new HashSet<CFormPermision>();
            CUser = new HashSet<CUser>();
        }

        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public DateTime? RplDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }

        public virtual ICollection<CFormPermision> CFormPermision { get; set; }
        public virtual ICollection<CUser> CUser { get; set; }
    }
}
