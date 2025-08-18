using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CView
    {
        public string ViewId { get; set; }
        public string MdlName { get; set; }
        public string SubMdlName { get; set; }
        public string ViewText { get; set; }
        public string ViewTextEn { get; set; }
        public string MenuId { get; set; }
    }
}
