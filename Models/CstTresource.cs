using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTresource
    {
        public CstTresource()
        {
            CstTresourceMaterialD = new HashSet<CstTresourceMaterialD>();
        }

        public string ResourceId { get; set; }
        public string WorkPackageId { get; set; }
        public string ResourceName { get; set; }
        public string Unit { get; set; }
        public string ExpType { get; set; }
        public string ResourceGroupId { get; set; }
        public string ResourceGroupL2Id { get; set; }
        public string ResourceGroupL3Id { get; set; }
        public string Temp { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstTresourceMaterialD> CstTresourceMaterialD { get; set; }
    }
}
