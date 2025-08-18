using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QuizQuestionCategory
    {
        public QuizQuestionCategory()
        {
            QuizQuestions = new HashSet<QuizQuestions>();
        }

        public int QuestionCatId { get; set; }
        public string QuestionCatName { get; set; }
        public int? QuestionCatCount { get; set; }

        public virtual ICollection<QuizQuestions> QuizQuestions { get; set; }
    }
}
