using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CUser
    {
        public CUser()
        {
            CUserDiscipline = new HashSet<CUserDiscipline>();
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public byte Contin { get; set; }
        public string Password { get; set; }
        public string GroupId { get; set; }
        public bool? CanConfirm { get; set; }
        public byte[] Signature { get; set; }
        public string DepartmentId { get; set; }
        public bool? CanOpenMailDepartment { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }
        public bool? AccCash { get; set; }
        public bool? CheckIn { get; set; }
        public bool? CheckOut { get; set; }
        public string ProcClass { get; set; }
        public string DisciplineCode { get; set; }
        public string TitleId { get; set; }
        public bool? Manager { get; set; }
        public string SubGroup { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public bool? ConfirmMail { get; set; }

        public virtual CDepartment Department { get; set; }
        public virtual CGroup Group { get; set; }
        public virtual ICollection<CUserDiscipline> CUserDiscipline { get; set; }
    }
}
