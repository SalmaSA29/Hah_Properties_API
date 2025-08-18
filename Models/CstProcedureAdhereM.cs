using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstProcedureAdhereM
    {
        public CstProcedureAdhereM()
        {
            CstProcedureAdhereD = new HashSet<CstProcedureAdhereD>();
        }

        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        public virtual ICollection<CstProcedureAdhereD> CstProcedureAdhereD { get; set; }
    }
}
