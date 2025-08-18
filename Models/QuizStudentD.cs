using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QuizStudentD
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? Serial { get; set; }
        public int? QuestId { get; set; }
        public int? RowNo { get; set; }
        public string AnswerId { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? UpDate { get; set; }
        public int? Degree { get; set; }

        public virtual QuizStudentM Student { get; set; }
    }
}
