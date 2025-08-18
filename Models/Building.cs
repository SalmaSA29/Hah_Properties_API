using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public partial class Building
    {
        public Building()
        {
            Requests = new HashSet<Requests>();
            Units = new HashSet<Units>();
        }

        public int Id { get; set; }
        public int ProjId { get; set; }
        public string Name { get; set; }
        public string InUser { get; set; }
        public DateTime InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual Projects Proj { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
        public virtual ICollection<Units> Units { get; set; }
    }
}
