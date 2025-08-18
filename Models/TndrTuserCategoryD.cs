using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrTuserCategoryD
    {
        public string ProjectId { get; set; }
        public string UserId { get; set; }
        public string CatId { get; set; }

        public virtual TndrTuserCategoryM TndrTuserCategoryM { get; set; }
    }
}
