using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class ItmCat_Category_Reference
    {
        public int ID { get; set; }

        public int Cat_ID { get; set; }

        public int Ref_ID { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

    }
}
