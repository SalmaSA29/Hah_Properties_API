using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class FolderPath
    {
        public int FolderId { get; set; }
        public string FolderPath1 { get; set; }
        public string FolderTitle { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public DateTime? LocalRplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }
    }
}
