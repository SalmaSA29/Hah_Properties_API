using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class LegalAffairType
    {
        public int AffairTypeId { get; set; }
        public string AffairName { get; set; }
        public string Inuser { get; set; }
        public DateTime? Indate { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
