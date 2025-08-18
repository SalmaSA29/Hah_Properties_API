using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstPfrM
    {
        public CstPfrM()
        {
            CstPfrD = new HashSet<CstPfrD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public double? ExpectedRev { get; set; }
        public double? BudgetGrossMargin { get; set; }
        public DateTime? Date { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstPfrD> CstPfrD { get; set; }
    }
}
