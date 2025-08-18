using System;

namespace PortalAPI.Models.InformationTechnology
{
    public class ItmCat_Manufaturals
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Notes { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
        public string Up_User { get; set; }
        public DateTime? Up_Date { get; set; }
    }
}
