using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfTitle
    {
        public int TitleId { get; set; }
        public string DepartmentId { get; set; }
        public string TitleName { get; set; }
        public string Grade_ID { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
    }
}
