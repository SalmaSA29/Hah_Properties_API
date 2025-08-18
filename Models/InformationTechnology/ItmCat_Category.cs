using PortalAPI.Models.MDM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public class ItmCat_Category
    {
        public ItmCat_Category()
        {
            Category_Attach = new HashSet<ItmCat_Category_Attach>();
            Category_AttachDiscuss = new HashSet<ItmCat_Category_DiscussionAttach>();
        }

        [Key]
        public int cat_id { get; set; }

        public int Parent_ID { get; set; }

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


        public virtual ICollection<ItmCat_Category_Attach> Category_Attach { get; set; }
        public virtual ICollection<ItmCat_Category_DiscussionAttach> Category_AttachDiscuss { get; set; }


    }
}
