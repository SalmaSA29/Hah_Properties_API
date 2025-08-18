using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public partial class Requests
    {
        public int Id { get; set; }
        public string Hrcode { get; set; }
        public int ProjId { get; set; }
        public int BuildingsId { get; set; }
        public int UnitId { get; set; }
        public string Description { get; set; }
        public int PaymentPlanId { get; set; }
        public string SharingUsers { get; set; }
        public int Status { get; set; }
        public string InUser { get; set; }
        public DateTime InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual Buildings Buildings { get; set; }
        public virtual PaymentPlans PaymentPlan { get; set; }
        public virtual Projects Proj { get; set; }
        public virtual Units Unit { get; set; }
    }
}
