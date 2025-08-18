using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstScCertificate
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public int AgreementNo { get; set; }
        public DateTime? Date { get; set; }
        public double? WorkDoneProject { get; set; }
        public double? WorkDoneSubmit { get; set; }
        public double? WorkDoneApp { get; set; }
        public double? WorkDoneActual { get; set; }
        public double? WorkDonePaid { get; set; }
        public double? MaterialOnSiteProject { get; set; }
        public double? MaterialOnSiteSubmit { get; set; }
        public double? MaterialOnSiteApp { get; set; }
        public double? MaterialOnSiteActual { get; set; }
        public double? MaterialOnSitePaid { get; set; }
        public double? AddedLabor { get; set; }
        public double? AddedMaterial { get; set; }
        public double? AddedEquipment { get; set; }
        public double? AddedOther { get; set; }
        public double? DeductedPerformanceGuarantee { get; set; }
        public double? DeductedTaxes { get; set; }
        public double? DeductedRelation { get; set; }
        public double? DeductedAdPaymentRecovery { get; set; }
        public double? DeductedCummAePayment { get; set; }
        public double? DeductedProjectDeduction { get; set; }
        public double? DeductedAccDeduction { get; set; }
        public string Comments { get; set; }
        public string Notes { get; set; }
        public double? FinalAmount { get; set; }
        public double? FinalProject { get; set; }
        public double? FinalSubmit { get; set; }
        public double? FinalApp { get; set; }
        public double? FinalActual { get; set; }
        public double? FinalPaid { get; set; }
        public double? TotalAdded { get; set; }
        public double? TotalDed { get; set; }
    }
}
