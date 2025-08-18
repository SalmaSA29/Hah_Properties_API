using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebWfMoqEvalD
    {
        public int RecordNo { get; set; }
        public string UserRating { get; set; }
        public int EvalNo { get; set; }
        public int Rank { get; set; }
        public string ToUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
