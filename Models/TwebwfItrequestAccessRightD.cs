using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItrequestAccessRightD
    {
        public int Id { get; set; }
        public int RequestNo { get; set; }
        public int AccessId { get; set; }

        public virtual TwebwfItaccessRight Access { get; set; }
        public virtual TwebwfItrequestAccessRight RequestNoNavigation { get; set; }
    }
}
