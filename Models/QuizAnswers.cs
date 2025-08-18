using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QuizAnswers
    {
        public int AnswerId { get; set; }
        public int QuestId { get; set; }
        public int? RowNo { get; set; }
        public string AnswerShortcut { get; set; }
        public string AnswerName { get; set; }
        public string AnswerImg { get; set; }
        public bool? IsCorrect { get; set; }
    }
}
