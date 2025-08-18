using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CDb
    {
        public CDb()
        {
            CDepartment = new HashSet<CDepartment>();
            CEmp = new HashSet<CEmp>();
            COperation = new HashSet<COperation>();
            CTaxPlaceG = new HashSet<CTaxPlaceG>();
            CTaxPlaceS = new HashSet<CTaxPlaceS>();
            CYear = new HashSet<CYear>();
            Currency = new HashSet<Currency>();
        }

        public string DbId { get; set; }
        public string DbName { get; set; }
        public bool? MainDb { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public bool? CanUpd { get; set; }

        public virtual ICollection<CDepartment> CDepartment { get; set; }
        public virtual ICollection<CEmp> CEmp { get; set; }
        public virtual ICollection<COperation> COperation { get; set; }
        public virtual ICollection<CTaxPlaceG> CTaxPlaceG { get; set; }
        public virtual ICollection<CTaxPlaceS> CTaxPlaceS { get; set; }
        public virtual ICollection<CYear> CYear { get; set; }
        public virtual ICollection<Currency> Currency { get; set; }
    }
}
