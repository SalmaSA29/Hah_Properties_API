using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models
{
    public class TWEBWFSubsidiaries
    {
        public int SubID { get; set; }
        public string SubName { get; set; }
        public string SubIcone { get; set; }
        public string SubDesc { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
    }
}
