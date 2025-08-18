using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecHacEmployee
    {
        public string UserHrCode { get; set; }
        public string DepartmentId { get; set; }
        public string LocationId { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string StName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ManagerCode { get; set; }
        public string TitleId { get; set; }
        public string AccountStatus { get; set; }
        public string WindowsAccount { get; set; }
        public string Email { get; set; }
        public string DeskPhone { get; set; }
        public bool? Internet { get; set; }
        public bool? Usb { get; set; }
        public bool? BbService { get; set; }
        public bool? Vbn { get; set; }
        public string Pcorlab { get; set; }
        public string TagName { get; set; }
        public bool? LocalPrinter { get; set; }
        public string PrinterNu { get; set; }
        public string Manager { get; set; }
        public string GradeId { get; set; }
        public string ResidenceId { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Mobile1 { get; set; }
        public DateTime? HireDate { get; set; }
        public string AccommodationId { get; set; }
        public string RoomNo { get; set; }
        public string Comments { get; set; }
        public string ProjectId { get; set; }
        public string Status { get; set; }
        public string LinkedIn { get; set; }
        public string Skype { get; set; }
        public string ImgProfile { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Cv { get; set; }
        public string NationalId { get; set; }
        public string PersonalEmail { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Street { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsActive { get; set; }
        public string SupportFun { get; set; }
        public int? ChildrenCount { get; set; }
        public int? InterviewId { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
    }
}
