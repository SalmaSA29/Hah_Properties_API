using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrTitemsSetCategory
    {
        public int RecordId { get; set; }
        public string ItemNo { get; set; }
        public string ProjectId { get; set; }
        public string DepId { get; set; }
        public string SubCatId { get; set; }
        public double? BasicCurrencyUsd { get; set; }
        public double? BasicSupplyIn { get; set; }
        public double? BasicCustomSalesFees { get; set; }
        public double? BasicMaintainanceSparePartsWarranty { get; set; }
        public double? BasicTotalUnitBasicMaterialUsd { get; set; }
        public double? BasicTotalUnitBasicMaterialSar { get; set; }
        public double? MechHookUpAndValves { get; set; }
        public double? MechAccessories { get; set; }
        public double? MechDampers { get; set; }
        public double? MechVsd { get; set; }
        public double? MechSupportsSiesmec { get; set; }
        public double? MechCivilWorks { get; set; }
        public double? MechMaterialTransp { get; set; }
        public double? MechElectricalConnection { get; set; }
        public double? MechControl { get; set; }
        public double? MechTotalUnitAuxiliaryMaterialsItemsMech { get; set; }
        public double? ElecAccessories { get; set; }
        public double? ElecWastage { get; set; }
        public double? ElecTransportation { get; set; }
        public double? ElecCablesWires { get; set; }
        public double? ElecCoduits { get; set; }
        public double? ElecCableTray { get; set; }
        public double? ElecMechWorks { get; set; }
        public double? ElecCivilWorks { get; set; }
        public double? ElecTotalUnitAuxiliaryMaterialsItemsElec { get; set; }
        public double? IndustrialNdt { get; set; }
        public double? IndustrialPwht { get; set; }
        public double? IndustrialPainting { get; set; }
        public double? IndustrialRefractory { get; set; }
        public double? IndustrialInsulation { get; set; }
        public double? IndustrialPmi { get; set; }
        public double? IndustrialPt { get; set; }
        public double? IndustrialHardness { get; set; }
        public double? IndustrialPreheating { get; set; }
        public double? IndustrialTotalUnitIndustrial { get; set; }
        public double? WorkManshipMhr { get; set; }
        public double? WorkManshipManPowerLabor { get; set; }
        public double? WorkManshipToolsConsumables { get; set; }
        public double? WorkManshipConstructionEquip { get; set; }
        public double? WorkManshipTransportationAndAccommodation { get; set; }
        public double? WorkManshipTestingAndBalancing { get; set; }
        public double? WorkManshipTotalUnitWorkManship { get; set; }
        public double? SubcontractorUsd { get; set; }
        public double? SubcontractorSar { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
