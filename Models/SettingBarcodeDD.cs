using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SettingBarcodeDD
    {
        public string FormId { get; set; }
        public string TableName { get; set; }
        public string BarcodeField { get; set; }
        public string Value { get; set; }
        public string Equivalent { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public bool? CanUpd { get; set; }

        public virtual SettingBarcodeD SettingBarcodeD { get; set; }
    }
}
