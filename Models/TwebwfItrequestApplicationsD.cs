using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItrequestApplicationsD
    {
        public int Id { get; set; }
        public int RequestNo { get; set; }
        public int ApplicationItemId { get; set; }
        public string Other { get; set; }

        public virtual TwebwfItrequestApplications RequestNoNavigation { get; set; }
    }
}
