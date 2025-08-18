using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class PH_Models
    {
        [Key]
        public int ID { get; set; }

        public int Brand_ID { get; set; }
        [ForeignKey("Brand_ID")]
        public PH_Brands PH_Brands { get; set; }

        public string Name { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

    }
}
