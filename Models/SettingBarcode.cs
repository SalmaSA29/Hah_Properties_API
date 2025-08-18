using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SettingBarcode
    {
        public string FormId { get; set; }
        public string TableName { get; set; }
        public bool? Active { get; set; }
        public string BarcodeField { get; set; }
        public string BarCodeTable { get; set; }
        public string BarCodeTableKey { get; set; }
        public int? MasterIdFrom { get; set; }
        public int? MasterIdTo { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public bool? CanUpd { get; set; }
    }
}
