using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrVisaEmployeeAlgeria
    {
        public int DocNo { get; set; }
        public string VisaJobTitleId { get; set; }
        public string Code { get; set; }
        public string EmployeeName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string ResponsablePerson { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Age { get; set; }
        public string PassportNo { get; set; }
        public string MilitaryStatusId { get; set; }
        public string DepartStatusId { get; set; }
        public DateTime? DepartDate { get; set; }
        public string NationalId { get; set; }
        public string AuthorizeNo { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? PresentingDate { get; set; }
        public string DbId { get; set; }
        public string Project { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
