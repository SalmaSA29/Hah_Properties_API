using PortalAPI.Models.MDM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public class ItmCat_Admin
    {
        public int ID { get; set; }
        public string HRCode { get; set; }

        public int? Group_ID { get; set; }
        [ForeignKey("Group_ID")]
        public ItmCat_Groups? Group { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
        public string Up_User { get; set; }
        public DateTime? Up_Date { get; set; }

        [NotMapped]
        public List<int> companies_List { get; set; }
    }
}
