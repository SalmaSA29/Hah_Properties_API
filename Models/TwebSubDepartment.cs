using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebSubDepartment
    {
        public TwebSubDepartment()
        {
            TwebContactList = new HashSet<TwebContactList>();
        }

        public int SubDepartmentId { get; set; }
        public int DepartmentId { get; set; }
        public string SubDepartmentName { get; set; }

        public virtual TwebDepartment Department { get; set; }
        public virtual ICollection<TwebContactList> TwebContactList { get; set; }
    }
}
