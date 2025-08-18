using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public partial class Units
    {
        public Units()
        {
            Requests = new HashSet<Requests>();
            UnitPaymentPlan = new HashSet<UnitPaymentPlan>();
        }
        [JsonIgnore]
        public int Id { get; set; }
        public int No { get; set; }
        public int Type { get; set; }
        public int Area { get; set; }
        public decimal Price { get; set; }
        public string? Attach { get; set; }
        public int BuildingsId { get; set; }
        [NotMapped]
        public ICollection<int> UnitPaymentPlanIds { get; set; }    // Used to avoid making another DTO, in the request it is used to get the possible payment plans
        [JsonIgnore]
        public string InUser { get; set; }
        [JsonIgnore]
        public DateTime InDate { get; set; }
        [JsonIgnore]
        public string UpUser { get; set; }
        [JsonIgnore]
        public DateTime? UpDate { get; set; }

        [JsonIgnore]
        public virtual Buildings Buildings { get; set; }
        [JsonIgnore]
        public virtual ICollection<Requests> Requests { get; set; }
        [JsonIgnore]
        public virtual ICollection<UnitPaymentPlan> UnitPaymentPlan { get; set; }
    }
}
