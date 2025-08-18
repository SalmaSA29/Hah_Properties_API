using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class LegalAffair
    {
        public string AffairNo { get; set; }
        public string AffairYear { get; set; }
        public DateTime? RegDate { get; set; }
        public int? Gid { get; set; }
        public int? AffairTypeId { get; set; }
        public int? CustId { get; set; }
        public string EnemyName { get; set; }
        public string Othercust { get; set; }
        public string Otherenemy { get; set; }
        public int? Custcharge { get; set; }
        public int? Encharge { get; set; }
        public string CustAddress { get; set; }
        public string EnAddress { get; set; }
        public string CustPaper { get; set; }
        public string CustAttachment { get; set; }
        public string EnPaper { get; set; }
        public string EnAttachment { get; set; }
        public int? LawyerId { get; set; }
        public string EnLawyer { get; set; }
        public string Subject { get; set; }
        public string Notes { get; set; }
        public string Fileno { get; set; }
        public string Automatedno { get; set; }
        public string Floor { get; set; }
        public string CircleNo { get; set; }
        public string Inuser { get; set; }
        public DateTime? Indate { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
