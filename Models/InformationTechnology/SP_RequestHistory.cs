using System;
using System.Collections.Generic;

namespace PortalAPI.Models.InformationTechnology
{
    public class SP_RequestHistory
    {
        //public SP_RequestHistory()
        //{
        //    request = new HashSet<ItmCat_Item_Request>();
        //}
        public int ID { get; set; }
        public int? Group_ID { get; set; }
        public int? RequestNo { get; set; }
        public int? Cat_ID { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
        public int? Action { get; set; }
        public string Submitted_HrCode { get; set; }
        public DateTime? Submitted_Date { get; set; }
        public string Submitted_Comment { get; set; }
        public int? FindItemCode { get; set; }
        public string Action_Name { get; set; }
        public string Cat_Name { get; set; }
        public string User_Action { get; set; }
        public string Item_Name { get; set; }
        public string ItemCode { get; set; }
        public string ProjectName { get; set; }
        public string OD_Hrcode { get; set; }
        public string OD_Name { get; set; }
        public string Department_ID { get; set; }
        public string Department_Name { get; set; }
        //public ItmCat_Item_Request request { get; set; }
        //public virtual ICollection<ItmCat_Item_Request> request { get; set; }
    }
}
