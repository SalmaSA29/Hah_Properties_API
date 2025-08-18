using System;
using System.Collections.Generic;

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

        public int Id { get; set; }
        public int No { get; set; }
        public int Type { get; set; }
        public int Area { get; set; }
        public decimal Price { get; set; }
        public string Attach { get; set; }
        public int BuildingId { get; set; }
        public string InUser { get; set; }
        public DateTime InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual Building Building { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
        public virtual ICollection<UnitPaymentPlan> UnitPaymentPlan { get; set; }
    }
}
