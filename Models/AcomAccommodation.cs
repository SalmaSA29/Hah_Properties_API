using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AcomAccommodation
    {
        public string AccommodationId { get; set; }
        public string AccommodationDesc { get; set; }
        public string AccommodationTypeId { get; set; }
        public int? NoOfRooms { get; set; }
        public int? PersonCapacity { get; set; }
        public string LocationId { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string ContractNo { get; set; }
        public double? TotalCost { get; set; }
        public double? CostPerEmployee { get; set; }
        public string AccProviderId { get; set; }
        public bool? Active { get; set; }
        public string Address { get; set; }
        public string ResidenceId { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Mobile1 { get; set; }
        public string ContactPerson { get; set; }
        public string Comments { get; set; }
        public string ProjectId { get; set; }
    }
}
