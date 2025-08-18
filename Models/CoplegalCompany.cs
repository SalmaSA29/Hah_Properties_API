using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CoplegalCompany
    {
        public int CompId { get; set; }
        public string CompName { get; set; }
        public string Inuser { get; set; }
        public DateTime? InDate { get; set; }
        public string Upuser { get; set; }
        public DateTime? Updateuser { get; set; }
        public string Logo { get; set; }
    }
}
