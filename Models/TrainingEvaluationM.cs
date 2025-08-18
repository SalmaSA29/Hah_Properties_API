using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrainingEvaluationM
    {
        public int CourseDet { get; set; }
        public int CourseId { get; set; }
        public string UserHrCode { get; set; }
        public string ElementLikedMost { get; set; }
        public string ElementDidntLike { get; set; }
        public string ElementSuggestions { get; set; }
        public DateTime? InDate { get; set; }
    }
}
