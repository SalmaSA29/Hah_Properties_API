using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebLog
    {
        public string UserEmail { get; set; }
        public DateTime? Date { get; set; }
        public int Serl { get; set; }
        public DateTime? DateOnly { get; set; }
    }
}
