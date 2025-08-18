using System;

namespace PortalAPI.Models.InformationTechnology
{
    public class ItmCat_Items_Deleted
    {

        public int ID { get; set; }
        public int? Item_ID { get; set; }
        public int? Cat_ID { get; set; }
        public string SystemItemCode { get; set; }
        public string ItemCode { get; set; }
        public int? Item_UOM { get; set; }
        public int? Item_MatGroup { get; set; }
        public int? Item_MatType { get; set; }
        public string Item_Name { get; set; }
        public string Item_Desc { get; set; }
        public string Item_Photo { get; set; }
        public string Tags { get; set; }
        public bool? EnableBrand { get; set; }
        public bool? EnableColor { get; set; }
        public bool? ExpirationDateFlag { get; set; }
        public string ArabicDesc { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }


    }
}
