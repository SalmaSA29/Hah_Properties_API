using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrProjectInformation
    {
        public string ProjectId { get; set; }
        public byte[] ProjectLogo { get; set; }
        public int? ClientLegalStructure { get; set; }
        public DateTime? ProjectContractualStartDate { get; set; }
        public DateTime? ProjectActualStartDate { get; set; }
        public DateTime? ContractualCompletionDate { get; set; }
        public DateTime? ActualCompletionDate { get; set; }
        public string ProjectPlannedDuration { get; set; }
        public string ProjectActualDuration { get; set; }
        public int? ProjectClassification { get; set; }
        public int? ProjectClassificationType { get; set; }
        public int? TypeOContract { get; set; }
        public int? TypeOContractType { get; set; }
        public int? HacRoleAs { get; set; }
        public string PartnersNames { get; set; }
        public string LegalNameOfConsortiumOrJv { get; set; }
        public int? MainScopeOfWork { get; set; }
        public string WorkingHoursShifts { get; set; }
        public string BreakHours { get; set; }
        public double? ContarctAmount { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
