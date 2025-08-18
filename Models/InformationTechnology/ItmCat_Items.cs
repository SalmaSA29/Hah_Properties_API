using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class ItmCat_Items
    {
        public ItmCat_Items()
        {
            Items_Attaches = new HashSet<ItmCat_Item_Attach>();
            Items_Attaches_Discuss = new HashSet<ItmCat_Item_DiscussionAttach>();
            Items_Manufactureres = new HashSet<ItmCat_Items_Manufactureres>();
        }

        [Key]
        public int Item_ID { get; set; }

        public int? RequestNo { get; set; }

        public string SystemItemCode { get; set; }

        public string ItemCode { get; set; }

        public string Item_Name { get; set; }

        public string Item_Desc { get; set; }

        public int? Item_Qty { get; set; }

        public double? Item_Price { get; set; }

        public bool? Item_AppearPrice { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

        public virtual ICollection<ItmCat_Item_Attach> Items_Attaches { get; set; }
        public virtual ICollection<ItmCat_Item_DiscussionAttach> Items_Attaches_Discuss { get; set; }

        [ForeignKey("ItemID")]
        public virtual ICollection<ItmCat_Items_Manufactureres> Items_Manufactureres { get; set; }


        public int? Cat_ID { get; set; }
        [ForeignKey("Cat_ID")]
        public ItmCat_Category Category { get; set; }

        public int? Item_UOM { get; set; }
        [ForeignKey("Item_UOM")]
        public ItmCat_UOM ItmCat_UOM { get; set; }

        public int? Item_MatGroup { get; set; }
        [ForeignKey("Item_MatGroup")]
        public ItmCat_Material_Group MatrialGroup { get; set; }

        public int? Item_MatType { get; set; }
        [ForeignKey("Item_MatType")]
        public ItmCat_Material_Type MaterialType { get; set; }


        public string Item_Photo { get; set; }
        public string Tags { get; set; }
        public bool? EnableBrand { get; set; }
        public bool? EnableQuality  { get; set; }
        public bool? ExpirationDateFlag { get; set; }
        public string ArabicDesc { get; set; }



    }
}
