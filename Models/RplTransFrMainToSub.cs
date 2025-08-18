using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RplTransFrMainToSub
    {
        public int Serial { get; set; }
        public string TableName { get; set; }
        public string TableMasterName { get; set; }
        public string SudbfieldInTable { get; set; }
        public string Sudbtable { get; set; }
        public string Sudbfield { get; set; }
    }
}
