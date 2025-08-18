using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecWebTraining
    {
        public int? SeekerId { get; set; }
        public int TrainId { get; set; }
        public string Institution { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Certificate { get; set; }
        public string FieldOfStudy { get; set; }

        public virtual HrSeekerWeb Seeker { get; set; }
    }
}
