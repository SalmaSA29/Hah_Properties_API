using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrainingEvaluationCourses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Provider { get; set; }
        public string Trainer { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? DurationDays { get; set; }
        public string Location { get; set; }
        public int? Venue { get; set; }
        public string Cost { get; set; }
    }
}
