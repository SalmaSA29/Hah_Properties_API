using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CFormConfirmUserD
    {
        public string FormId { get; set; }
        public string ConfirmName { get; set; }
        public string UserId { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }

        public virtual CFormConfirmUserM Form { get; set; }
    }
}
