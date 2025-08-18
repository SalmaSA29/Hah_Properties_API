using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItaccessRight
    {
        public TwebwfItaccessRight()
        {
            TwebwfItrequestAccessRightD = new HashSet<TwebwfItrequestAccessRightD>();
        }

        public int AccessId { get; set; }
        public string AccessName { get; set; }
        public bool? IsUserAccount { get; set; }

        public virtual ICollection<TwebwfItrequestAccessRightD> TwebwfItrequestAccessRightD { get; set; }
    }
}
