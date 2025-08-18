using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SP_DashBoard_AccessCompany
    {
        public int ID { get; set; }
        public string Department_Name { get; set; }
        public string Department_Image { get; set; }
        public double Staff_Count { get; set; }
        public double Staff_Attend { get; set; }
        public double Labor_Count { get; set; }
        public double Labor_Attend { get; set; }
        public double SubContractor { get; set; }
    }
}
