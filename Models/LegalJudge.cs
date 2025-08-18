using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class LegalJudge
    {
        public int Gid { get; set; }
        public string GName { get; set; }
        public string Inuser { get; set; }
        public DateTime? Indate { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
