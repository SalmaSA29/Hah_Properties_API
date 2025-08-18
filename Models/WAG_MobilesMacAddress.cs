using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WAG_MobilesMacAddress
    {
        public int ID { get; set; }
        public int? Project_ID { get; set; }
        public string Mobile_MacAddress { get; set; }
        public string Owner_HRCode { get; set; }
    }
}
