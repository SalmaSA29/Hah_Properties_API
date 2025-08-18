using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SP_GetEmpByProj
    {
        public Int64 ID { get; set; }
        public string staffno { get; set; }
        public string HRcode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Islabour { get; set; }
        public bool Active { get; set; }
        public bool? FaceRegister { get; set; }
    }
}
