using System;
using System.ComponentModel.DataAnnotations;

namespace PortalAPI.Models.InformationTechnology
{
    public class SP_RequestReport
    {
        [Key]
        public int RequestID { get; set; }
        public string Item_Name { get; set; }
        public string Item_Desc { get; set; }
        public string ItemCode { get; set; }
        public string Parent_Cat_Name { get; set; }
        public string Cat_Name { get; set; }
        public string status { get; set; }
        public string Group_Step { get; set; }
        public string matGroupName { get; set; }
        public string matTypName { get; set; }
        public string requestHRCode { get; set; }
        public string requestName { get; set; }
        public string requestEmail { get; set; }
        public DateTime? requestDate { get; set; }
        public DateTime? completedDate { get; set; }
        public string requestCompany { get; set; }
        public string requestPrjct { get; set; }
        public string bHRCode { get; set; }
        public string bName { get; set; }
        public string bEmail { get; set; }
        public string bAction { get; set; }
        public DateTime? bSubDate { get; set; }
        public string pHRCode { get; set; }
        public string pName { get; set; }
        public string pEmail { get; set; }
        public string pAction { get; set; }
        public DateTime? pSubDate { get; set; }
        public string mHRCode { get; set; }
        public string mName { get; set; }
        public string mEmail { get; set; }
        public string mAction { get; set; }
        public DateTime? mSubDate { get; set; }

    }
}
