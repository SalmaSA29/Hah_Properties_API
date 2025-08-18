using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItassetsEquipments
    {
        public int AssetsId { get; set; }
        public int? HardWareItemId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceSerial { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public string Comment { get; set; }
    }
}
