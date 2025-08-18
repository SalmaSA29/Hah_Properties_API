using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TalentWorkFlow
    {
        public int WfId { get; set; }
        public int? Id { get; set; }
        public string ActionUser { get; set; }
        public int? ActionState { get; set; }
        public string AssignTo { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Comment { get; set; }
        public int? Check1 { get; set; }
        public string Check1Comm { get; set; }
        public int? Check2 { get; set; }
        public string Check2Comm { get; set; }
        public int? Check3 { get; set; }
        public string Check3Comm { get; set; }
        public int? Check4 { get; set; }
        public string Check4Comm { get; set; }
        public int? Check5 { get; set; }
        public string Check5Comm { get; set; }
        public int? Check6 { get; set; }
        public string Check6Comm { get; set; }
        public int? Check7 { get; set; }
        public string Check7Comm { get; set; }
        public bool? StepActive { get; set; }
    }
}
