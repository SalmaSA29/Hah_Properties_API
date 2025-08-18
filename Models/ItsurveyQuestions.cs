using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItsurveyQuestions
    {
        public int QuestId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionCatId { get; set; }
        public string QuestType { get; set; }
        public string QuesName { get; set; }
        public string QuesArname { get; set; }
    }
}
