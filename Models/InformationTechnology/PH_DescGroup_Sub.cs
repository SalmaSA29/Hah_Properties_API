using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace PortalAPI.Models.InformationTechnology
{
    public class PH_DescGroup_Sub
    {
        public PH_DescGroup_Sub()
        {
            DescGroup_Values = new HashSet<PH_DescGroup_Values>();
        }
        public int ID { get; set; }
        public int? Desc_ID { get; set; }
        public string Sub_Name { get; set; }
        [ForeignKey("SubDesc_ID")]
        public ICollection<PH_DescGroup_Values> DescGroup_Values { get; set; }
    }
}
