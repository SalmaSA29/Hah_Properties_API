using System;
using System.Collections.Generic;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class PH_Assets_Trans
    {
        public int ID { get; set; }

        public int? Asset_ID { get; set; }

        public string BarCode { get; set; }

        public int? Action { get; set; }

        public int? Store_ID { get; set; }

        public string Assined_HRCode { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }


    }
}
