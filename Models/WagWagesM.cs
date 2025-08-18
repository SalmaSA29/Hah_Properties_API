using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagWagesM
    {
        public WagWagesM()
        {
            WagWagesD = new HashSet<WagWagesD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public DateTime Date { get; set; }
        public string SiteEngineerUserHrCode { get; set; }
        public string Remarks { get; set; }
        public string WorkType { get; set; }
        public string Scorhac { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual ICollection<WagWagesD> WagWagesD { get; set; }
    }
}
