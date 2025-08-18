using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Conditions
    {
        public string ConditionTable { get; set; }
        public string ConditionFiled { get; set; }
        public string TableName { get; set; }
        public string Filter { get; set; }
    }
}
