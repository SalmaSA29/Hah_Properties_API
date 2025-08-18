using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrainingEvaluationElements
    {
        public int ElementsId { get; set; }
        public int? CategoryId { get; set; }
        public string ElementsEn { get; set; }
        public string ElementsAr { get; set; }
    }
}
