using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstIrLog
    {
        public int Sn { get; set; }
        public string ProjectId { get; set; }
        public int RecordId { get; set; }
        public string Ref { get; set; }
        public string LocationArea { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Part { get; set; }
        public string Grd { get; set; }
        public string LocationAxis { get; set; }
        public string Discipline { get; set; }
        public string WorkType { get; set; }
        public string WorkDescription { get; set; }
        public string Code { get; set; }

        public virtual CstIrLogM CstIrLogM { get; set; }
    }
}
