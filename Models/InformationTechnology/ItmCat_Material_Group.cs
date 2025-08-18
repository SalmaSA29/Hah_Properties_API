using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class ItmCat_Material_Group
    {
        public int ID { get; set; }

        public string Material_Name { get; set; }
        public string Group_Desc { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

    }
}
