using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanMakeOrBuyAnalysis
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public byte[] AttFile { get; set; }
        public string FilePath { get; set; }
        public string FileExt { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
