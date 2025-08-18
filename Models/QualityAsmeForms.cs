using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QualityAsmeForms
    {
        public int FrmId { get; set; }
        public int? ProId { get; set; }
        public string FrmName { get; set; }
        public string FrmFile { get; set; }
        public string FrmCode { get; set; }
        public DateTime? FrmDate { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
