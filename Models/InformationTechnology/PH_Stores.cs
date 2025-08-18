using System;
using System.Collections.Generic;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class PH_Stores
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

    }
}
