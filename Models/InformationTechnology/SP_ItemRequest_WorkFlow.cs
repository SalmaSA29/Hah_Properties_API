using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace PortalAPI.Models.InformationTechnology
{

    public class SP_ItemRequest_WorkFlow
    {
        public SP_ItemRequest_WorkFlow()
        {
            WorkFlow = new HashSet<ItmCat_Item_Request_Workflow>();
            //Item_Manufactureres = new HashSet<ItmCat_Item_Request_Manufactureres>();
        }
        [Key]
        public int RequestID { get; set; }


        //public virtual ICollection<ItmCat_Item_Request_Manufactureres> Item_Manufactureres { get; set; }

        public int? FindItem_ID { get; set; }

        public int? Group_Step { get; set; }

        public int? Cat_ID { get; set; }
        [ForeignKey("Cat_ID")]
        public ItmCat_Category Category { get; set; }
        public string CategoryName { get; set; }

        public string SystemItemCode { get; set; }

        public string ItemCode { get; set; }

        public string Item_Name { get; set; }

        public string Item_Desc { get; set; }
        public string MainPhoto { get; set; }

        public int? Item_UOM { get; set; }
        [ForeignKey("Item_UOM")]
        public ItmCat_UOM ItemUOM { get; set; }

        public int? Item_MatGroup { get; set; }
        [ForeignKey("Item_MatGroup")]

        public ItmCat_Material_Group MatrialGroup { get; set; }

        public int? Item_MatType { get; set; }
        [ForeignKey("Item_MatType")]
        public ItmCat_Material_Type MaterialType { get; set; }
        public string Tags { get; set; }

        public int? Item_Qty { get; set; }

        public double? Item_Price { get; set; }

        public bool? Item_AppearPrice { get; set; }

        public int? status { get; set; }

        public string In_User { get; set; }

        public string Requester_Name { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

        [ForeignKey("RequestNo")]
        public virtual ICollection<ItmCat_Item_Request_Workflow> WorkFlow { get; set; }



        public bool? Brand_Enabled { get; set; }
        public bool? Quality_Enabled { get; set; }
        public string Department_ID { get; set; }
        public string Department_Name { get; set; }
    }
}
