using System;

namespace PortalAPI.Models.InformationTechnology
{
    public class PH_Assets_Attaches
    {
        public int ID { get; set; }
        public int? Asset_ID { get; set; }
        public string Assigned_HRCode { get; set; }
        public string Attach_Name { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
    }
}
