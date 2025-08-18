using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrainingEvaluationD
    {
        public int CourseDetId { get; set; }
        public int CourseDet { get; set; }
        public int ElementsId { get; set; }
        public string ElementsValue { get; set; }
        public string Comment { get; set; }
    }
}
