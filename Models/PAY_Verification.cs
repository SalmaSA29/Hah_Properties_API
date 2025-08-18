using NPOI.SS.UserModel;
using System;

namespace PortalAPI.Models
{
    public class PAY_Verification
    {
        public int ID { get; set; }
        public string UserHRCode { get; set; }
        public string VerificationCode { get; set; }
        public bool Closed { get; set; }
        public DateTime In_Date { get; set; }
        public string In_Use { get; set; }
  
    }
}
