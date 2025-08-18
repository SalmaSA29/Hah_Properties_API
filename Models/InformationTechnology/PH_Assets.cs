using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models.InformationTechnology
{
    public class PH_Assets
    {
        //AssetsAttach
        public PH_Assets()
        {
            AssetsAttach = new HashSet<PH_Assets_Attaches>();
        }

        public int ID { get; set; }
        public int? DeliveryDet_ID { get; set; }
        public int? Delivery_ID { get; set; }
        public int? PO_No { get; set; }
        public int? Store_ID { get; set; }
        public string Assined_HRCode { get; set; }
        public DateTime? Warranty { get; set; }
        public string BarCode { get; set; }
        public string SerialNo { get; set; }
        public int? Type_ID { get; set; }
        [ForeignKey("Type_ID")]
        public PH_Types PH_Types { get; set; }
        public int? Brand_ID { get; set; }
        [ForeignKey("Brand_ID")]
        public PH_Brands PH_Brands { get; set; }
        [ForeignKey("PH_Models")]
        public int? Model_ID { get; set; }
        [ForeignKey("Model_ID")]
        public PH_Models PH_Models { get; set; }
        public double? Unit_Price { get; set; }
        public double? Unit_Tax { get; set; }
        public double? Unit_TotalPrice { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
        public string Up_User { get; set; }
        public DateTime? Up_Date { get; set; }
        public int? DescGroup_ID { get; set; }
        [ForeignKey("DescGroup_ID")]
        public PH_DescGroup PH_DescGroup { get; set; }
        public int? Brand { get; set; }
        public int? Hard_Size { get; set; }
        public int? Hard_Type { get; set; }
        public int? HDD_Numbers { get; set; }
        public int? Laptop_Size { get; set; }
        public int? Model { get; set; }
        public int? Path { get; set; }
        public int? PC_Laptop { get; set; }
        public int? Processor_Type { get; set; }
        public long? Quantity { get; set; }
        public int? Ram_Size { get; set; }
        public int? Screen_Size { get; set; }
        public int? Serial_Number { get; set; }
        public int? Size { get; set; }
        public int? Type { get; set; }
        public int? Vga_Size { get; set; }
        public int? Wireless_LAN_Unit { get; set; }
        public string Comment { get; set; }
        public bool? Is_Active { get; set; }
        [ForeignKey("Asset_ID")]
        public virtual ICollection<PH_Assets_Attaches> AssetsAttach { get; set; }
    }
}
