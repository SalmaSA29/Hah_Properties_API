using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tequipement
    {
        public Tequipement()
        {
            TequipementRecommendedItemD = new HashSet<TequipementRecommendedItemD>();
            TequipmementD = new HashSet<TequipmementD>();
            TjobOrderM = new HashSet<TjobOrderM>();
        }

        public string EquipementId { get; set; }
        public string OldNum { get; set; }
        public string KmH { get; set; }
        public string EquipementTypeId { get; set; }
        public string Model { get; set; }
        public string ManfctureDate { get; set; }
        public string ControlBoard { get; set; }
        public string ChaseeNum { get; set; }
        public string EngineNo { get; set; }
        public string FuelType { get; set; }
        public string TransmissionNum { get; set; }
        public DateTime? CarLicenseEndDate { get; set; }
        public int? Qualify { get; set; }
        public int? Status { get; set; }
        public string EngineModel { get; set; }
        public string DriverId { get; set; }
        public string Power { get; set; }
        public string YearMade { get; set; }
        public byte[] Image { get; set; }
        public string EquipmentSn { get; set; }
        public string EquipmentArrangmentNo { get; set; }
        public string EngineSn { get; set; }
        public string EngineArrangmentNo { get; set; }
        public string TransmissionSnNo { get; set; }
        public string TransmissinoArrangmentNo { get; set; }
        public bool? OptionsCassete { get; set; }
        public bool? OptionsSpeaker { get; set; }
        public bool? OptionsAir { get; set; }
        public bool? OptionsAlert { get; set; }
        public bool? OptionsCenter { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public double? NetBookValue { get; set; }
        public double? InsuranceValue { get; set; }
        public double? MonthlyRentalValue { get; set; }
        public string AssetTag { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual ICollection<TequipementRecommendedItemD> TequipementRecommendedItemD { get; set; }
        public virtual ICollection<TequipmementD> TequipmementD { get; set; }
        public virtual ICollection<TjobOrderM> TjobOrderM { get; set; }
    }
}
