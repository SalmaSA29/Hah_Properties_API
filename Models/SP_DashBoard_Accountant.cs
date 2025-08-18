using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SP_DashBoard_Accountant
    {
        public int ID { get; set; }
        public string Typ { get; set; }
        public string GroupTyp { get; set; }
        public double Revenue_Currentyear { get; set; }
        public double Revenue_Cumulitive { get; set; }
        public double Cost_Currentyear { get; set; }
        public double Cost_Cumulitive { get; set; }
        public double Cash_In_Currentyear { get; set; }
        public double Cash_In_Cumulitive { get; set; }
        public double Cash_Out_Currentyear { get; set; }
        public double Cash_Out_Cumulitive { get; set; }
    }
}
