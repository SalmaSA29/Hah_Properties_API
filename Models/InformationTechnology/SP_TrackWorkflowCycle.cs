using System;

namespace PortalAPI.Models.InformationTechnology
{
    public class SP_TrackWorkflowCycle
    {
        public int ID { get; set; }
        public int? Group_ID { get; set; }
        public string Group_Name { get; set; }
        public int? Action { get; set; }
        public string Action_Desc { get; set; }
        public int? CatID_Workflow { get; set; }
        public string CatWorkflowName { get; set; }
        public string ActionByHRCode { get; set; }
        public string ActionByName { get; set; }
        public string ActionByEmail { get; set; }
        public DateTime? Submitted_Date { get; set; }
        public string Submitted_Comment { get; set; }
        public int? RequestID { get; set; }
        public int? FindItem_ID { get; set; }
        public int? Cat_ID { get; set; }
        public string Cat_Name { get; set; }
        public string ItemCode { get; set; }
        public string Item_Name { get; set; }
        public string Item_Desc { get; set; }
        public string Tags { get; set; }
        public string Requester_HRCode { get; set; }
        public string Requester_Name { get; set; }
        public string Requester_Email { get; set; }
        public DateTime? Request_Date { get; set; }
    }
}
