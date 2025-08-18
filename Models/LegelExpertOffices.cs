using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class LegelExpertOffices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Inuser { get; set; }
        public DateTime? Indate { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
