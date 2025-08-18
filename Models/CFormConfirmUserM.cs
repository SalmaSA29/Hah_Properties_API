using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CFormConfirmUserM
    {
        public CFormConfirmUserM()
        {
            CFormConfirmUserD = new HashSet<CFormConfirmUserD>();
        }

        public string FormId { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }

        public virtual CFormConfirm Form { get; set; }
        public virtual ICollection<CFormConfirmUserD> CFormConfirmUserD { get; set; }
    }
}
