using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public class ItmCat_Item_Request_Workflow
    {
        [Key]
        public int ID { get; set; }

        public int? Group_ID { get; set; }


        public int? RequestNo { get; set; }
        //public ItmCat_Item_Request Request { get; set; }

        public int? Cat_ID { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public int? Action { get; set; }

        public string Submitted_HrCode { get; set; }

        public DateTime? Submitted_Date { get; set; }

        public string Submitted_Comment { get; set; }

        public int? FindItemCode { get; set; }
    }
}
