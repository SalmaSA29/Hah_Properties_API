using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class V_MyRequest
    {
        public int ID { get; set; }
        public int? Request_No { get; set; }
        public string Service_ID { get; set; }
        public string Service_Name { get; set; }
        public string Title_Name { get; set; }
        public string ImgProfile { get; set; }
        public int? Req_Status { get; set; }
        public DateTime? Req_Date { get; set; }
        public string Full_Req { get; set; }
        public string Request_HR_Code { get; set; }
        public string Status_Name { get; set; }
        public string req_Name { get; set; }
        public string responsbleperson { get; set; }
        public DateTime? RDate { get; set; }
    }
}
