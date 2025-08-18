using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TestEmpD
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpPhone { get; set; }
        public string TestId { get; set; }

        public virtual TestCars Test { get; set; }
    }
}
