using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkUsersPermission
    {
        public int PermId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectDirector { get; set; }
        public string OperationManager { get; set; }
        public string OdAssistant1 { get; set; }
        public string OdAssistant2 { get; set; }
        public string CostControlEngineer { get; set; }
    }
}
