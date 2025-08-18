using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagEmployee
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Mobile1 { get; set; }
        public string JobTitleId { get; set; }
        public string GradeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string GroupId { get; set; }
        public double? DailyRate { get; set; }
        public string SalaryTypeId { get; set; }
        public double? WorkingHours { get; set; }
        public string ProjectId { get; set; }
        public string IdCardNo { get; set; }
        public string Comments { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Image { get; set; }
        public byte? Gender { get; set; }
        public string CriminalRecord { get; set; }
        public string IdFront { get; set; }
        public string IdBack { get; set; }
        public string Other { get; set; }
        public string OtherName { get; set; }
        public DateTime? MissionDate { get; set; }
        public int? MissionProId { get; set; }
        public bool? IsConfirmed { get; set; }
        public bool? IsBlock { get; set; }
        public string BlockReason { get; set; }
        public bool? FaceRegister { get; set; }
        public bool? Active { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
