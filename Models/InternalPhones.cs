using System;

namespace PortalAPI.Models
{
    public partial class InternalPhones
    {

        public int ID { get; set; }
        public string Project { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public int? ZoomExt { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
        public bool? zoom_voice { get; set; }
        public bool? Zoom_conference { get; set; }
        public bool? zoom_phone { get; set; }
        public bool? zoom_Video { get; set; }

    }
}
