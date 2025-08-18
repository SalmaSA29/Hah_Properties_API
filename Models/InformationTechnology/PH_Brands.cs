using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class PH_Brands
    {
        public int ID { get; set; }

        public int Type_ID { get; set; }
        [ForeignKey("Type_ID")]
        public virtual PH_Types PH_Types { get; set; }

        public string Name { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }
    }
}
