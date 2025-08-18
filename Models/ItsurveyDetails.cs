using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItsurveyDetails
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? Serial { get; set; }
        public int? QuestId { get; set; }
        public string Answer { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual ItsurveyMaster Emp { get; set; }
    }
}
