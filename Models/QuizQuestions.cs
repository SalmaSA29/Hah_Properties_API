using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QuizQuestions
    {
        public int QuestId { get; set; }
        public int QuizId { get; set; }
        public string QuesType { get; set; }
        public int QuestionCatId { get; set; }
        public string QuesName { get; set; }
        public string QuesImage { get; set; }
        public double? Rate { get; set; }

        public virtual QuizQuestionCategory QuestionCat { get; set; }
    }
}
