using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public partial class UnitPaymentPlan
    {
        public int PaymentPlan_ID { get; set; }
        public int Unit_ID { get; set; }

        public virtual PaymentPlans PaymentPlan { get; set; }
        public virtual Units Unit { get; set; }
    }
}
