using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItphysicalDUsers
    {
        public int PhysicalUsers { get; set; }
        public int ProjectId { get; set; }
        public int? RefProjectId { get; set; }
        public string DepartmentId { get; set; }
        public int? TypesId { get; set; }
        public string UserHrcode { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNo { get; set; }
        public string Size { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public DateTime? RecivedDate { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
