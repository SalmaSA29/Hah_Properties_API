using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class ItmCat_Items_Manufactureres
    {
        public int ID { get; set; }

        public int? ItemID { get; set; }

        public int? Manufacturer_ID { get; set; }

        public bool? IsManufacChecked { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }
    }
}
