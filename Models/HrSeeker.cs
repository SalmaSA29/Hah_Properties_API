using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrSeeker
    {
        public int SeekerId { get; set; }
        public int GroupId { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string JobTitle { get; set; }
        public int? JobTitleIdApplied { get; set; }
        public int? AppSourceId { get; set; }
        public DateTime? AppSourceText { get; set; }
        public int? DisciplineId { get; set; }
        public int? AppStatusId { get; set; }
        public int? JobCategoryId { get; set; }
        public int? JobTypeId { get; set; }
        public int? CareerLevelId { get; set; }
        public int? JobLocationId { get; set; }
        public int? IndustryId { get; set; }
        public int? FunctionId { get; set; }
        public double? YearsOfExperience { get; set; }
        public double? YearsOfExperienceOfSamePostion { get; set; }
        public double? MonthlySalary { get; set; }
        public string CareerObjective { get; set; }
        public int? TargetIndustryId { get; set; }
        public byte? Gender { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public int? MajorId { get; set; }
        public string YearOfGrade { get; set; }
        public bool? StillStudying { get; set; }
        public int? DegreeLevelId { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? Nationality { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public int? AddressCountryId { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public string ZipPostalCode { get; set; }
        public string Fax { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string NationId { get; set; }
        public string CvName { get; set; }
    }
}
