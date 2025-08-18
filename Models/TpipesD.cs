using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TpipesD
    {
        public int DocNo { get; set; }
        public string Area { get; set; }
        public string Plant { get; set; }
        public string ProcessU { get; set; }
        public string SubSys { get; set; }
        public string Pid { get; set; }
        public string PaintingSystem { get; set; }
        public string TestSystem { get; set; }
        public string PressureTest { get; set; }
        public string TestMedium { get; set; }
        public string IsometricCount { get; set; }
        public string IsometricNo { get; set; }
        public string SheetNo { get; set; }
        public string Rev { get; set; }
        public string WeldMapNo { get; set; }
        public string LineDesignation { get; set; }
        public double? LineSizeInch { get; set; }
        public string LineSizeMm { get; set; }
        public string FluidCode { get; set; }
        public string MaterialType { get; set; }
        public string PipingClass { get; set; }
        public string InsulationType { get; set; }
        public string Thickness { get; set; }
        public string OuterDiaMm { get; set; }
        public string SpoolCount { get; set; }
        public string SpoolId { get; set; }
        public string SpoolNo { get; set; }
        public string QtySpool { get; set; }
        public double? CountOfJoint { get; set; }
        public string WeldJointNo { get; set; }
        public string EstDiaMm { get; set; }
        public string Symbol1 { get; set; }
        public string IsoSymbol1OuterDia { get; set; }
        public string HeatNo1 { get; set; }
        public string CertNo1 { get; set; }
        public string Symbol2 { get; set; }
        public string IsoSymbol2OuterDia { get; set; }
        public string HeatNo2 { get; set; }
        public string CertNo2 { get; set; }
        public string EstDiaInch { get; set; }
        public string ShopWeldFielweld { get; set; }
        public string AreaSwFw { get; set; }
        public string DiaSwFw { get; set; }
        public string SwFw { get; set; }
        public string FitterNo { get; set; }
        public DateTime? FDate { get; set; }
        public string Fittername { get; set; }
        public double? FitUpDiaInch { get; set; }
        public string Smaw1 { get; set; }
        public string Smaw2 { get; set; }
        public string Gatw1 { get; set; }
        public string Gatw2 { get; set; }
        public string Smaw1Smaw2Gatw1Gatw2Smaw1Smaw2Gatw1Gatw2 { get; set; }
        public DateTime? WeldDate { get; set; }
        public string WpsNo { get; set; }
        public string RtReport { get; set; }
        public DateTime? RtDate { get; set; }
        public string PtReport { get; set; }
        public DateTime? PtDate { get; set; }
        public string UtReport { get; set; }
        public DateTime? UtDate { get; set; }
        public string MtReport { get; set; }
        public DateTime? MtDate { get; set; }
        public string PwhtReport { get; set; }
        public DateTime? PwhtDate { get; set; }
        public string HDReport { get; set; }
        public DateTime? HDDate { get; set; }
        public string Rev1 { get; set; }
        public DateTime? DateOfRecevie { get; set; }
        public string AddDeletePaintCode { get; set; }
        public string Rev11 { get; set; }
        public DateTime? DateOfRecevie1 { get; set; }
        public string AddDeletePaintCode1 { get; set; }

        public virtual Tpipes DocNoNavigation { get; set; }
    }
}
