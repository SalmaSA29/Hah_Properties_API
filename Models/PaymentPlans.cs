using PortalAPI.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public partial class PaymentPlans
    {
        public PaymentPlans()
        {
            Requests = new HashSet<Requests>();
            UnitPaymentPlan = new HashSet<UnitPaymentPlan>();
        }

        public int Id { get; set; }
        public string Plan { get; set; }
        public bool? IsActive { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
        public virtual ICollection<UnitPaymentPlan> UnitPaymentPlan { get; set; }
    }
}
