using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class V_Notification
    {
        public int ID { get; set; }
        public int? Request_No { get; set; }
        public string User_ID { get; set; }
        public string Name { get; set; }
        public string Service_ID { get; set; }
        public string Service_Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Detail_Approval_ID { get; set; }
        public string Status { get; set; }
        public string FullReq_No { get; set; }
        public string Request_HR_Code { get; set; }
        public DateTime? Req_Date { get; set; }
        public int? Req_Status { get; set; }
        public string req_comment { get; set; }
        public string req_Name { get; set; }
        public string ProjectName { get; set; }
        public string ImgProfile { get; set; }
        public string requesterEmail { get; set; }

    }
}
