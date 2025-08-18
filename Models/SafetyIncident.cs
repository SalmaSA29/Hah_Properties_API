using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SafetyIncident
    {
        public int IncidentId { get; set; }
        public int? IncidentNo { get; set; }
        public bool? Isthisworkrelated { get; set; }
        public string ReasonWorkRelated { get; set; }
        public string Isthisanincidentoranearmiss { get; set; }
        public DateTime? ReportedDate { get; set; }
        public string Whatwasaffected { get; set; }
        public string Category { get; set; }
        public string Agentofincident { get; set; }
        public string Incidentinjurysummary { get; set; }
        public DateTime? Occurrencedate { get; set; }
        public string Fulldescription { get; set; }
        public string Attachment { get; set; }
        public string Immediateactionstaken { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ActualseverityPeople { get; set; }
        public string ActualseverityEnvironment { get; set; }
        public string ActualseverityAssetproduction { get; set; }
        public string ActualseverityReputation { get; set; }
        public string PotentialseverityPeople { get; set; }
        public string PotentialseverityEnvironment { get; set; }
        public string PotentialseverityAssetproduction { get; set; }
        public string PotentialseverityReputation { get; set; }
        public string Personreportingincidentname { get; set; }
        public string Employmentcategory { get; set; }
        public int? IncLocId { get; set; }
        public int? ProjectId { get; set; }
    }
}
