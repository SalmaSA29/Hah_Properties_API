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
        public int Proj_ID { get; set; }
        public int Buildings_ID { get; set; }
        public int Unit_ID { get; set; }
        public string Description { get; set; }
        public int PaymentPlan_ID { get; set; }
        public string Sharing_Users { get; set; }
        public int Status { get; set; }
        public string In_User { get; set; }
        [JsonIgnore]
        public DateTime In_Date { get; set; }
        [JsonIgnore]
        public string Up_User { get; set; }
        [JsonIgnore]
        public DateTime? Up_Date { get; set; }
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
