using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebConJobList
    {
        public string JobListId { get; set; }
        public string JobListName { get; set; }
        public string JobListCat { get; set; }
        public bool? Active { get; set; }
    }
}
