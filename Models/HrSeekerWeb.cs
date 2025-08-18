using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrSeekerWeb
    {
        public HrSeekerWeb()
        {
            HrRecWebEducation = new HashSet<HrRecWebEducation>();
            HrRecWebProfHist = new HashSet<HrRecWebProfHist>();
            HrRecWebTraining = new HashSet<HrRecWebTraining>();
        }

        public int SeekerId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public string JobTitle { get; set; }
        public string Industries { get; set; }
        public int? JobTitleIdApplied { get; set; }
        public string BirthPlace { get; set; }
        public string PositionLevel { get; set; }
        public string MilitryService { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string MobilePhone { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public string NationId { get; set; }
        public int? Gender { get; set; }
        public string University { get; set; }
        public string LangAr { get; set; }
        public string LangEn { get; set; }
        public string LangFr { get; set; }
        public string LangOth { get; set; }
        public string CompOffice { get; set; }
        public string CompInternet { get; set; }
        public string CompEng { get; set; }
        public string CompOth { get; set; }
        public bool? OutOfEgypt { get; set; }
        public int? HaveApplied { get; set; }
        public DateTime? HaveAppliedDate { get; set; }
        public string HaveAppliedDep { get; set; }
        public int? HaveEmployed { get; set; }
        public DateTime? HaveEmployedDate { get; set; }
        public string HaveEmployedDep { get; set; }
        public int? MajorId { get; set; }
        public string YearOfGrade { get; set; }
        public DateTime? InDate { get; set; }
        public string CvName { get; set; }
        public bool? Online { get; set; }
        public string InUser { get; set; }
        public string Comment { get; set; }
        public DateTime? InDate1 { get; set; }

        public virtual ICollection<HrRecWebEducation> HrRecWebEducation { get; set; }
        public virtual ICollection<HrRecWebProfHist> HrRecWebProfHist { get; set; }
        public virtual ICollection<HrRecWebTraining> HrRecWebTraining { get; set; }
    }
}
