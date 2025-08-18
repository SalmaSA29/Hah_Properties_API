using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprEvlParamter
    {
        public int ParamterId { get; set; }
        public string ParamterName { get; set; }
        public string ParamterType { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
