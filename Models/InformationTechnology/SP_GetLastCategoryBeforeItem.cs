using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public class SP_GetLastCategoryBeforeItem
    {
        [Key]
        public int Cat_ID { get; set; }
        public int? Parent_ID { get; set; }
        public string Cat_Name { get; set; }
        public string Cat_Code { get; set; }
        public string Cat_Desc { get; set; }
        public string Cat_Photo { get; set; }
        public DateTime? Cat_StartDate { get; set; }
        public DateTime? Cat_EndDate { get; set; }
        public string Tags { get; set; }
        public bool? IsActive { get; set; }
        public bool? Allow_Items { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
        public string Up_User { get; set; }
        public DateTime? Up_Date { get; set; }

        // Fields from ItmCat_Category_Attach table
        public int? Attachment_Id { get; set; }
        public string attach_file { get; set; }
        public string Attachment_In_User { get; set; }
        public DateTime? Attachment_In_Date { get; set; }
        public string Attachment_Up_User { get; set; }
        public DateTime? Attachment_Up_Date { get; set; }
    }
}
