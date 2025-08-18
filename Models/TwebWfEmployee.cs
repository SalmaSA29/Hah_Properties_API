using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models
{
    public partial class TwebWfEmployee
    {
        public string UserHrCode { get; set; }
        public int? FingerPrintGroup { get; set; }
        public string SAP_HRCode { get; set; }
        public string DepartmentId { get; set; }
        public int? MainDepartmentID { get; set; }
        public int? MainFunctionID { get; set; }
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
        public int? Accommodation { get; set; }
        public int? AccommodationType { get; set; }
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
        public string SupportFun { get; set; }
        public int? ChildrenCount { get; set; }
        public int? InterviewId { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public bool? IsActive { get; set; }
        public bool? Alg_Isdirect { get; set; }
        public DateTime? Alg_Enterdate { get; set; }
        public string Alg_Passno { get; set; }
        public DateTime? Alg_StartPassdate { get; set; }
        public DateTime? Alg_EndPassdate { get; set; }
        public string Alg_AddressPass { get; set; }
        public string Alg_VisaNo { get; set; }
        public string Alg_VisaPlace { get; set; }
        public string Alg_Visaoccup { get; set; }
        public DateTime? Alg_VisaStartdate { get; set; }
        public DateTime? Alg_VisaEnddate { get; set; }
        public string Alg_StayNo { get; set; }
        public string Alg_StayPlace { get; set; }
        public DateTime? Alg_Staystartdate { get; set; }
        public DateTime? Alg_Stayenddate { get; set; }
        public string Alg_StayType { get; set; }
        public string Alg_Warrantyno { get; set; }
        public string Alg_Warrantyplace { get; set; }
        public DateTime? Alg_WarrantyDate { get; set; }
        public string Alg_holidaycredit { get; set; }
        public string Alg_holidayticketcredit { get; set; }
        public DateTime? Alg_GraduationYeardate { get; set; }
        public string Alg_Major { get; set; }
        public string Alg_University { get; set; }
        public string Alg_personalPhone { get; set; }
        public string Alg_companyphoneno { get; set; }
        public string Alg_personalEmail { get; set; }
        public string Alg_CompanyEmail { get; set; }
        public string Alg_AccountNo { get; set; }
        public DateTime? Alg_startcontract { get; set; }
        public DateTime? Alg_endcontract { get; set; }
        public bool? FaceRegister { get; set; }
        public string PayrollPass { get; set; }
        public bool? zoom_phone { get; set; }
        public bool? zoom_voice { get; set; }
        public bool? zoom_conference { get; set; }
        public bool? zoom_Video { get; set; }
    }
}
