using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebDepartment
    {
        public TwebDepartment()
        {
            TwebSubDepartment = new HashSet<TwebSubDepartment>();
        }

        public int DepartmentId { get; set; }
        public string DepatmentName { get; set; }
        public string BusUnite { get; set; }

        public virtual ICollection<TwebSubDepartment> TwebSubDepartment { get; set; }
    }
}
