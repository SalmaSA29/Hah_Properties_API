using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebUser
    {
        public int FUserId { get; set; }
        public string FUserName { get; set; }
        public string UserEmail { get; set; }
        public string FUserPassWord { get; set; }
        public string NationalId { get; set; }
        public string PersonalEmail { get; set; }
        public bool? UseNationaId { get; set; }
        public string PhoneExt { get; set; }
        public DateTime? FLastLoginDate { get; set; }
        public byte? UserContinuous { get; set; }
        public string UserPassword { get; set; }
        public bool? CanConfirm { get; set; }
        public byte[] UserSignature { get; set; }
        public string UserMobile1 { get; set; }
        public string UserMobile2 { get; set; }
        public string FLastIp { get; set; }
        public string FullName { get; set; }
        public bool? Confirmed { get; set; }
        public bool? Admin { get; set; }
        public DateTime? Date { get; set; }
        public bool? Manager { get; set; }
        public string DepartmentId { get; set; }
        public string UserHrCode { get; set; }
        public string TitleId { get; set; }
        public string GradeId { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
