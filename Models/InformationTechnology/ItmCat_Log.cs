using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public partial class ItmCat_Log
    {
        public int ID { get; set; }

        public string HRCode { get; set; }

        public int? Action { get; set; }

        public string Table_Name { get; set; }

        public int? item_Code { get; set; }

        public DateTime? Date { get; set; }

    }
}
