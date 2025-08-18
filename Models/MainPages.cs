using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MainPages
    {
        public int PageId { get; set; }
        public int SysId { get; set; }
        public string PageName { get; set; }
        public string PageArTitle { get; set; }
        public string PageEnTitle { get; set; }
        public string PageArDesc { get; set; }
        public string PageEnDesc { get; set; }
    }
}
