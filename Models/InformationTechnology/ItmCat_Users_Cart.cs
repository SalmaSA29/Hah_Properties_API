using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class ItmCat_Users_Cart
    {

        public int ID { get; set; }

        public int? OrderID { get; set; }

        public string HRCode { get; set; }
        public int? Item_Code { get; set; }
        [ForeignKey("Item_Code")]
        public ItmCat_Items? ItmCat_Items { get; set; }

        public int? Item_Qty { get; set; }

        public bool? IsClosed { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

    }
}
