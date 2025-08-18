using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MaterialRequestM
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public DateTime? MrDate { get; set; }
        public string MrNo { get; set; }
        public string ExpType { get; set; }
        public double? BudgetToDate { get; set; }
        public double? ExpendedToDate { get; set; }
        public double? ExVariance { get; set; }
        public double? BudgetAtCompletion { get; set; }
        public double? Forecast { get; set; }
        public double? Variance { get; set; }
        public string ControlsManagerComment { get; set; }
        public string ControlsManagerUserId { get; set; }
        public DateTime? ControlsManagerDate { get; set; }
        public string StockControlManagerComment { get; set; }
        public string StockControlManagerUserId { get; set; }
        public DateTime? StockControlManagerDate { get; set; }
        public string BuyerId { get; set; }
        public string PurchasingDepartmentManagerComment { get; set; }
        public string PurchasingDepartmentManagerUserId { get; set; }
        public DateTime? PurchasingDepartmentManagerDate { get; set; }
        public int? CheckOk { get; set; }
        public string OperationDirectorComment { get; set; }
        public string OperationDirectorUserId { get; set; }
        public DateTime? OperationDirectorDate { get; set; }
    }
}
