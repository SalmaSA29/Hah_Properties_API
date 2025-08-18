using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public class PH_DescGroup
    {
        public PH_DescGroup()
        {
            DescGroup_Sub = new HashSet<PH_DescGroup_Sub>();
        }
        [Key]
        public int ID { get; set; }
        public string  Name { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
        public string Up_User { get; set; }
        public DateTime? Up_Date { get; set; }
        [ForeignKey("Desc_ID")]
        public  ICollection<PH_DescGroup_Sub> DescGroup_Sub { get; set; }
    }
}
