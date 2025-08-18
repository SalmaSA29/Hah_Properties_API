using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public partial class Buildings
    {
        public Buildings()
        {
            Requests = new HashSet<Requests>();
            Units = new HashSet<Units>();
        }
        [JsonIgnore]
        public int Id { get; set; }
        public int ProjId { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public string InUser { get; set; }
        [JsonIgnore]
        public DateTime InDate { get; set; }
        [JsonIgnore]
        public string UpUser { get; set; }
        [JsonIgnore]
        public DateTime? UpDate { get; set; }

        [JsonIgnore]
        public virtual Projects Proj { get; set; }
        [JsonIgnore]
        public virtual ICollection<Requests> Requests { get; set; }
        [JsonIgnore]
        public virtual ICollection<Units> Units { get; set; }
    }
}
