using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public partial class Projects
    {
        public Projects()
        {
            Building = new HashSet<Building>();
            Requests = new HashSet<Requests>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string InUser { get; set; }
        public DateTime InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual ICollection<Building> Building { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
