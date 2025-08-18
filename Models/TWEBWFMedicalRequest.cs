using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models
{
    public class TWEBWFMedicalRequest
    {
        public int ID { get; set; }
        public string HrCode { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string Beneficiaryname { get; set; }
        public string Servicetype { get; set; }
        public string LabType { get; set; }
        public DateTime? InDate { get; set; }
     
    }
}
