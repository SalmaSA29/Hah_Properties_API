using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.InformationTechnology
{
    public class ItmCat_UsersCompany
    {

        public int ID { get; set; }

        public string User_HRCode { get; set; }
        public int Company_ID { get; set; }

        public string In_User { get; set; }

        public DateTime? In_Date { get; set; }

        public string Up_User { get; set; }

        public DateTime? Up_Date { get; set; }

    }
}
