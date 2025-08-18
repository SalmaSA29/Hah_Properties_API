using System;

namespace PortalAPI.Models.InformationTechnology
{
    public class ItmCat_Category_DiscussionAttach
    {
        public int ID { get; set; }
        public int? Cat_ID { get; set; }
        public string Attach_File { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
        public string Up_User { get; set; }
        public DateTime? Up_Date { get; set; }
    }
}
