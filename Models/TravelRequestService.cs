using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models
{
    public class TravelRequestService
    {
        [Key]
        public int servID { get; set; }
        public string servname { get; set; }
        public string Fieldname { get; set; }
    }
}
