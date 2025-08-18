using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models
{
    public partial class SP_DashBoard_Projects
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string Projects_Director { get; set; }
        public string Name { get; set; }
        public string shortcut { get; set; }
        public int CEmployees { get; set; }
        public int Employees { get; set; }
        public int PercEmp { get; set; }
        public int CLabors { get; set; }
        public int Labors { get; set; }
        public int PercLabor { get; set; }
        public int TotalSignin { get; set; }
        public int TotalPerc { get; set; }
        public int SubContractor { get; set; }
    }

}
