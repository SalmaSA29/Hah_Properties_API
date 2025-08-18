using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebContactList
    {
        public int ConId { get; set; }
        public int SubDepartmentId { get; set; }
        public string ConName { get; set; }
        public string ConExt { get; set; }
        public string ConEmail { get; set; }
        public string ExternalNo { get; set; }
        public string IpPhone { get; set; }
        public string UserHrCode { get; set; }
        public string Floor { get; set; }
        public string AccessCode { get; set; }
        public string CarNo { get; set; }
        public string Mobile { get; set; }

        public virtual TwebSubDepartment SubDepartment { get; set; }
    }
}
