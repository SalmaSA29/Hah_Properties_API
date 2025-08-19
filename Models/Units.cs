using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    // the model extraction happens FromForm instead of FromBody thus BindNever is important
    public partial class Units
    {
        public Units()
        {
            Requests = new HashSet<Requests>();
            UnitPaymentPlan = new HashSet<UnitPaymentPlan>();
        }
        [JsonIgnore]
        [BindNever]
        public int Id { get; set; }
        public int No { get; set; }
        public int Type { get; set; }
        public int Area { get; set; }
        public decimal Price { get; set; }
        public string Attach { get; set; }
        public int BuildingsId { get; set; }

        [NotMapped]
        public IFormFile Media { get; set; } = null;
        [NotMapped]
        public ICollection<int> UnitPaymentPlanIds { get; set; }    // Used to avoid making another DTO, in the request it is used to get the possible payment plans
        
        [JsonIgnore]
        [BindNever]
        public string InUser { get; set; }
        [JsonIgnore]
        [BindNever]
        public DateTime InDate { get; set; }
        [JsonIgnore]
        [BindNever]
        public string UpUser { get; set; }
        [JsonIgnore]
        [BindNever]
        public DateTime? UpDate { get; set; }

        [JsonIgnore]
        [BindNever]
        public virtual Buildings Buildings { get; set; }
        [JsonIgnore]
        [BindNever]
        public virtual ICollection<Requests> Requests { get; set; }
        [JsonIgnore]
        [BindNever]
        public virtual ICollection<UnitPaymentPlan> UnitPaymentPlan { get; set; }
    }
}
