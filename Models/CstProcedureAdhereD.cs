using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstProcedureAdhereD
    {
        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Serial { get; set; }
        public DateTime? ManPowerPl { get; set; }
        public DateTime? ManPowerAct { get; set; }
        public DateTime? PlanningPl { get; set; }
        public DateTime? PlanningAct { get; set; }
        public DateTime? QsdataPl { get; set; }
        public DateTime? QsdataAct { get; set; }
        public DateTime? IrlogPl { get; set; }
        public DateTime? IrlogAct { get; set; }

        public virtual CstProcedureAdhereM CstProcedureAdhereM { get; set; }
    }
}
