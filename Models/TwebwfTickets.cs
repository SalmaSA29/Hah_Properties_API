using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfTickets
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Unit { get; set; }
        public int? ProjectId { get; set; }
        public string RequestedBy { get; set; }
        public string ProbDesc { get; set; }
        public DateTime? StartDate { get; set; }
        public string DoneBy { get; set; }
        public string ActionTaken { get; set; }
        public int? Status { get; set; }
        public int? Precentage { get; set; }
        public DateTime? ExpectedEndDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Remarks { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
