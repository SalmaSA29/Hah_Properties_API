using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class DTypeG
    {
        public byte DTypeG1 { get; set; }
        public string Descrp { get; set; }
        public string DescrpEn { get; set; }
        public string TabelMasterName { get; set; }
        public string TabelMasterNameView { get; set; }
        public bool? MultiDTypeS { get; set; }
        public string FieldDTypeSTable { get; set; }
        public string FieldDTypeS { get; set; }
        public string FieldDTypeSName { get; set; }
        public bool? HasDescrp { get; set; }
        public bool? HasOpNo { get; set; }
        public bool? HasCenterId { get; set; }
        public bool? HasInWorkOrderNo { get; set; }
        public bool? HasExWorkOrderNo { get; set; }
        public bool? HasPoGl { get; set; }
        public bool? HasPricing { get; set; }
        public string SpName { get; set; }
    }
}
