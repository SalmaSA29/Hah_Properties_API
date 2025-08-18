using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CDepartment
    {
        public CDepartment()
        {
            CEmp = new HashSet<CEmp>();
            CUser = new HashSet<CUser>();
        }

        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string ParentId { get; set; }
        public string ChildId { get; set; }
        public bool Main { get; set; }
        public byte Levl { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }

        public virtual CDb Db { get; set; }
        public virtual ICollection<CEmp> CEmp { get; set; }
        public virtual ICollection<CUser> CUser { get; set; }
    }
}
