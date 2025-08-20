using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public static class RequestsStatus
    {
        public const int Pending = 1;
        public const int InProgress = 2;
        public const int Rejected = 3;
    }
    public partial class Requests
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public string Hrcode { get; set; }
        public int ProjId { get; set; }
        public int BuildingsId { get; set; }
        public int UnitId { get; set; }
        public string Description { get; set; }
        public int PaymentPlanId { get; set; }
        public string SharingUsers { get; set; }
        public int Status { get; set; }
        [JsonIgnore]
        public string InUser { get; set; }
        [JsonIgnore]
        public DateTime InDate { get; set; }
        [JsonIgnore]
        public string UpUser { get; set; }
        [JsonIgnore]
        public DateTime? UpDate { get; set; }
        [JsonIgnore]
        public bool? IsActive { get; set; }

        [JsonIgnore]
        public virtual Buildings Buildings { get; set; }
        [JsonIgnore]
        public virtual PaymentPlans PaymentPlan { get; set; }
        [JsonIgnore]
        public virtual Projects Proj { get; set; }
        [JsonIgnore]
        public virtual Units Unit { get; set; }
    }
}
