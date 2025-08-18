using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QuizQuiz
    {
        public QuizQuiz()
        {
            QuizStudentM = new HashSet<QuizStudentM>();
        }

        public int QuizId { get; set; }
        public string QuizName { get; set; }
        public int? QuizTime { get; set; }
        public double? QuizGrade { get; set; }
        public double? QuizSuccess { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<QuizStudentM> QuizStudentM { get; set; }
    }
}
