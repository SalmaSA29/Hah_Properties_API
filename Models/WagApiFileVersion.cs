using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagApiFileVersion
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string FilesName { get; set; }
        public string FileSize { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; } 
    }
}
