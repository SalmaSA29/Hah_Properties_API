using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class InternalMeetingProjects
    {
        public int ProjId { get; set; }
        public int? ClassId { get; set; }
        public string Name { get; set; }
        public string Inuser { get; set; }
        public DateTime? InDate { get; set; }
        public string Upuser { get; set; }
        public DateTime? Updateuser { get; set; }
        public int? DirectorId { get; set; }
        public string UserEmail { get; set; }
    }
}
