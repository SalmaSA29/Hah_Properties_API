using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CFormPermision
    {
        public string FormId { get; set; }
        public string GroupId { get; set; }
        public bool? CanOpen { get; set; }
        public bool? CanAdd { get; set; }
        public bool? CanUpdate { get; set; }
        public bool? CanDelete { get; set; }
        public bool? CanNavigate { get; set; }
        public bool CanPost { get; set; }
        public bool CanUnPost { get; set; }
        public bool CanPrice { get; set; }
        public bool CanUnPrice { get; set; }
        public bool CanEntry { get; set; }
        public bool CanUnEntry { get; set; }
        public bool? CanViewReport { get; set; }
        public bool CanViewJournal { get; set; }
        public bool? CanAddAttachment { get; set; }
        public bool? CanShowAttachment { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }
        public string MenuId { get; set; }
        public int? FormIndex { get; set; }

        public virtual CForm Form { get; set; }
        public virtual CGroup Group { get; set; }
    }
}
