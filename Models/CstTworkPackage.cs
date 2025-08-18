using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTworkPackage
    {
        public string WorkPackageId { get; set; }
        public string WorkPackage { get; set; }
        public string ExpType { get; set; }
        public string ResourceId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
