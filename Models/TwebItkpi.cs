using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebItkpi
    {
        public int ItawarenesId { get; set; }
        public string ItawarenesName { get; set; }
        public string FileName { get; set; }
        public string Year { get; set; }
        public int? Month { get; set; }
    }
}
