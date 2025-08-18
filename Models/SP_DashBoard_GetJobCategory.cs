using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models
{
    public partial class SP_DashBoard_GetJobCategory
    {
        public Int64 ID { get; set; }
        public string Status { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
        public bool Islabor { get; set; }
    }
}
