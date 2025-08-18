using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfService
    {
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ApprovalPathId { get; set; }
        public string System { get; set; }
        public string PageName { get; set; }
        public string TableName { get; set; }
        public string ReportName { get; set; }
        public string SerachFiledName { get; set; }
    }
}
