using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public class SP_PH_assetsDataAll
    {

        [Key]
        public long id { get; set; }
        public int? asset_ID { get; set; }
        public int? tpe_id { get; set; }
        public string tpe_nme { get; set; }
        public int? brnd_id { get; set; }
        public string brnd_name { get; set; }
        public int? modl_id { get; set; }
        public string modl_name { get; set; }
        public string barcode { get; set; }
        public string serial_no { get; set; }
        public string hr_code { get; set; }
        public string employe_name { get; set; }
        public string title_id { get; set; }
        public string title_name { get; set; }
        public string emp_email { get; set; }
        public int? store_id { get; set; }
        public string store_name { get; set; }

    }
}
