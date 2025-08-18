using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models.InformationTechnology
{
    public class PH_Delivery_M_Attaches
    {

        public int ID { get; set; }

        public int? Delivery_M_ID { get; set; }
        [ForeignKey("Delivery_M_ID")]
        public virtual PH_Delivery_M_Attaches PH_Delivery_Attaches { get; set; }
        public string Attach_Name { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
    }
}
