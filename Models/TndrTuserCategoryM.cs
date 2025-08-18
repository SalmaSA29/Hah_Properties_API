using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrTuserCategoryM
    {
        public TndrTuserCategoryM()
        {
            TndrTuserCategoryD = new HashSet<TndrTuserCategoryD>();
        }

        public string ProjectId { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<TndrTuserCategoryD> TndrTuserCategoryD { get; set; }
    }
}
