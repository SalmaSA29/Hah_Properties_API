using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QuizStudentM
    {
        public QuizStudentM()
        {
            QuizStudentD = new HashSet<QuizStudentD>();
        }

        public int StudentId { get; set; }
        public int? QuizId { get; set; }
        public string StudentName { get; set; }
        public string StudentUniversity { get; set; }
        public string StudentMajor { get; set; }
        public string StudentGraduationYear { get; set; }
        public string StudentAccumulativeGrade { get; set; }
        public string StudentMobile { get; set; }
        public string StudentEmail { get; set; }
        public string StudentMilitaryStatus { get; set; }
        public string StudentNationalId { get; set; }
        public string StudentHrcode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Closed { get; set; }
        public int? Resualt { get; set; }

        public virtual QuizQuiz Quiz { get; set; }
        public virtual ICollection<QuizStudentD> QuizStudentD { get; set; }
    }
}
