using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ConditionReport
    {
        public string FormId { get; set; }
        public string TableName { get; set; }
        public string ConditionFiled { get; set; }
        public string Filter { get; set; }
        public string FormText { get; set; }
    }
}
