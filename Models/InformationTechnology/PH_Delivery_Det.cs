using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class PH_Delivery_Det
    {
        public int ID { get; set; }

        public int? Delivery_ID { get; set; }

        public int PO_No { get; set; }

        public int Type_ID { get; set; }
        [ForeignKey("Type_ID")]
        public PH_Types PH_Types { get; set; }

        public int Brand_ID { get; set; }
        [ForeignKey("Brand_ID")]
        public PH_Brands PH_Brands { get; set; }

        public int Model_ID { get; set; }
        [ForeignKey("Model_ID")]
        public PH_Models PH_Models { get; set; }

        public double? Unit_Price { get; set; }

        public int? Unit_Qty { get; set; }

        public double? Unit_TotalPrice { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }
    }
}
