using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.MDM
{
    public partial class ItmCat_Items_History
    {
        public int ID { get; set; }

        public int Cat_ID { get; set; }

        public string SystemItemCode { get; set; }

        public string ItemCode { get; set; }

        public int Item_Type { get; set; }

        public string Item_Name { get; set; }

        public string Item_Desc { get; set; }

        public int Item_UOM { get; set; }

        public int Item_MatGroup { get; set; }

        public int Item_Qty { get; set; }

        public double Item_Price { get; set; }

        public bool Item_AppearPrice { get; set; }

        public bool Allow_Request { get; set; }

        public string In_User { get; set; }

        public DateTime In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

    }

}
