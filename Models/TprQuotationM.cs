using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprQuotationM
    {
        public TprQuotationM()
        {
            TprQuotationD1 = new HashSet<TprQuotationD1>();
            TprQuotationD2 = new HashSet<TprQuotationD2>();
            TprQuotationD3 = new HashSet<TprQuotationD3>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public DateTime Date { get; set; }
        public string Descrp { get; set; }
        public double? CurrenyQuoted { get; set; }
        public double? ExchangeRateUsed { get; set; }
        public string MaterialDeliveryPeriod { get; set; }
        public string CurrencyId { get; set; }
        public double? Rate { get; set; }
        public double? Transportation { get; set; }
        public double? PackingTransportation { get; set; }
        public double? Freight { get; set; }
        public double? Insurance { get; set; }
        public double? CustomDutiesLearance { get; set; }
        public double? LoadingTransportation { get; set; }
        public double? OffLoadingAtSite { get; set; }
        public string Misc { get; set; }
        public double? FeesTaxes { get; set; }
        public string PaymentConditions { get; set; }
        public string PaymentConditionsOther { get; set; }
        public double? PerformanceBond { get; set; }
        public double? AdvPayment { get; set; }
        public double? PaymentOnDelivery { get; set; }
        public double? PaymentOnInstallation { get; set; }
        public double? Retention { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryFrom { get; set; }
        public string DeliveryTo { get; set; }
        public string DeliveryBasdon { get; set; }
        public byte? PbLgOrChq { get; set; }
        public byte? AdvPLgOrChq { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public double? DiscountD1 { get; set; }
        public double? DiscountD2 { get; set; }
        public double? DiscountD3 { get; set; }

        public virtual ICollection<TprQuotationD1> TprQuotationD1 { get; set; }
        public virtual ICollection<TprQuotationD2> TprQuotationD2 { get; set; }
        public virtual ICollection<TprQuotationD3> TprQuotationD3 { get; set; }
    }
}
