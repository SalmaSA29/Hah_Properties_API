using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprProjectManager
    {
        public string ProjectManagerId { get; set; }
        public string ProjectManagerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public byte? ProjectManager { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
