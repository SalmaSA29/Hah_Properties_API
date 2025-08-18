using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SettingBarcodeD
    {
        public SettingBarcodeD()
        {
            SettingBarcodeDD = new HashSet<SettingBarcodeDD>();
        }

        public string FormId { get; set; }
        public string TableName { get; set; }
        public string BarcodeField { get; set; }
        public int? BarCodeFrom { get; set; }
        public int? BarCodeTo { get; set; }
        public string FieldTitleAr { get; set; }
        public string FieldTitleEn { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public bool? CanUpd { get; set; }

        public virtual ICollection<SettingBarcodeDD> SettingBarcodeDD { get; set; }
    }
}
