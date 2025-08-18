using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class COperation
    {
        public int OpNo { get; set; }
        public string Descrp { get; set; }
        public string CustId { get; set; }
        public string DescrpProject { get; set; }
        public string PlaceProject { get; set; }
        public string CenterId { get; set; }
        public byte LoadingCost { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public bool? CanUpd { get; set; }

        public virtual CDb Db { get; set; }
    }
}
