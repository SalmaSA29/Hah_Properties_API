using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalAPI.Models
{
    public partial class SP_TicketingAPI_Employees
    {   
        [Key]
        public string Name { get; set; }
        public string User_HR_Code { get; set; }
        public string SAP_HRCode { get; set; }
        public string Email { get; set; }
        public string Desk_Phone { get; set; }
        public string ST_Name { get; set; }
        public string Last_Name { get; set; }
        public string Title_Name { get; set; }
        public int? Title_ID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyID { get; set; }
        public string ProjectName { get; set; }
        public int? Project_ID { get; set; }
        public int? Department_ID { get; set; }
        public string Department_Name { get; set; }
        public string Mobile { get; set; }
        public string Level_Name { get; set; }
        public int? Level_ID { get; set; }
        public DateTime? HireDate { get; set; }
        public string Manage_Tech_Email { get; set; }
        public string Manage_Dir_Email { get; set; }
        public string Proj_Manage_Email { get; set; }
        public string Proj_HR_Coordinator { get; set; }
    }
}
