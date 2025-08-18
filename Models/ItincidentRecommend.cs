using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItincidentRecommend
    {
        public int RecId { get; set; }
        public int? IncId { get; set; }
        public string RecAction { get; set; }
        public string RecOwner { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }

        public virtual ItincidentM Inc { get; set; }
    }
}
