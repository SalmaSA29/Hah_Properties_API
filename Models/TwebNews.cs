using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebNews
    {
        public int NewsId { get; set; }
        public string NewsDescription { get; set; }
        public string NewsBody { get; set; }
        public string NewsTitleAr { get; set; }
        public string NewsBodyAr { get; set; }
        public DateTime? NewsDate { get; set; }
        public string NewsTitle { get; set; }
        public int? FIndex { get; set; }
        public int? Ftype { get; set; }
        public bool? Active { get; set; }
        public int? NoOfDays { get; set; }
        public int? NewsType { get; set; }
    }
}
