using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class PH_Delivery_M
    {
        public PH_Delivery_M()
        {
            PH_Delivery_Det = new HashSet<PH_Delivery_Det>();
            PH_Delivery_M_Attaches = new HashSet<PH_Delivery_M_Attaches>();
        }

        [Key]
        public int Delivery_ID { get; set; }

        public int PO_No { get; set; }

        public string Provider_Comp { get; set; }

        public string Provider_Name { get; set; }

        public string Provider_DocNo { get; set; }

        public DateTime? ShipmentDate { get; set; }

        public string File1 { get; set; }

        public string File2 { get; set; }

        public string File3 { get; set; }

        public string File4 { get; set; }

        public string File5 { get; set; }

        public double? TotalPrice { get; set; }
        public double? AddOnTotal { get; set; }
        public double? DiscOnTotal { get; set; }
        public double? Tax { get; set; }
        public double? FinalPrice { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

        public virtual ICollection<PH_Delivery_Det> PH_Delivery_Det { get; set; }
        [ForeignKey("Delivery_M_ID")]
        public virtual ICollection<PH_Delivery_M_Attaches> PH_Delivery_M_Attaches { get; set; }
    }
}
