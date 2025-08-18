using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkProcurement
    {
        public TrkProcurement()
        {
            TrkProcuremantComments = new HashSet<TrkProcuremantComments>();
            TrkProcurementD = new HashSet<TrkProcurementD>();
        }

        public int ProcurementId { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackage { get; set; }
        public int AgreementNo { get; set; }
        public string SupplierId { get; set; }
        public int? DocNo { get; set; }
        public int? ProcTypeId { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public string PoAmount { get; set; }
        public double? PoBudget { get; set; }
        public string PoAmountCur { get; set; }
        public int? PoDelevryTerms { get; set; }
        public string PoApRate { get; set; }
        public string PoAp { get; set; }
        public string PoUponDelvRate { get; set; }
        public string PoUponDelv { get; set; }
        public string PoRetentionRate { get; set; }
        public string PoRetention { get; set; }
        public string PoStartUpRate { get; set; }
        public string PoStartUp { get; set; }
        public bool? RetentionReq { get; set; }
        public bool? Lgperformance { get; set; }
        public int? DeliveryFrom { get; set; }
        public int? DeliveryTo { get; set; }
        public DateTime? PoDate { get; set; }
        public string LgAdvPayAmount { get; set; }
        public string Comments { get; set; }
        public string FileAttached { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public string DelvPart1 { get; set; }
        public DateTime? DelvPart1date { get; set; }
        public DateTime? DelvPartDateRec1 { get; set; }
        public string DelvPart2 { get; set; }
        public DateTime? DelvPart2date { get; set; }
        public DateTime? DelvPartDateRec2 { get; set; }
        public string DelvPart3 { get; set; }
        public DateTime? DelvPart3date { get; set; }
        public DateTime? DelvPartDateRec3 { get; set; }
        public string DelvPart4 { get; set; }
        public DateTime? DelvPart4date { get; set; }
        public DateTime? DelvPartDateRec4 { get; set; }
        public int? Status { get; set; }
        public string PoApAmountCur { get; set; }

        public virtual ICollection<TrkProcuremantComments> TrkProcuremantComments { get; set; }
        public virtual ICollection<TrkProcurementD> TrkProcurementD { get; set; }
    }
}
