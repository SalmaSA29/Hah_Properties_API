using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstPfrD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string ExpType { get; set; }
        public double? PfrAmount { get; set; }
        public double? CurrentBudget { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstPfrM CstPfrM { get; set; }
    }
}
