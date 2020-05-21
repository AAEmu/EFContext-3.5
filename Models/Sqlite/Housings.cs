using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Housings
    {
        public Housings()
        {
            HousingBindingDoodads = new HashSet<HousingBindingDoodads>();
            HousingBuildSteps = new HashSet<HousingBuildSteps>();
            HousingPackMembers = new HashSet<HousingPackMembers>();
            HousingRebuildings = new HashSet<HousingRebuildings>();
        }

        public long Id { get; set; }
        public long? AbsoluteDecoLimit { get; set; }
        public double? Alley { get; set; }
        public byte[] AlwaysPublic { get; set; }
        public byte[] AutoZ { get; set; }
        public double? AutoZOffsetX { get; set; }
        public double? AutoZOffsetY { get; set; }
        public double? AutoZOffsetZ { get; set; }
        public long? CategoryId { get; set; }
        public double? CinemaRadius { get; set; }
        public long? CinemaId { get; set; }
        public byte[] DecoExpandability { get; set; }
        public long? DecoLimit { get; set; }
        public long? DemolishRefundItemId { get; set; }
        public long? DoorModelId { get; set; }
        public double? ExtraHeightAbove { get; set; }
        public double? ExtraHeightBelow { get; set; }
        public string Family { get; set; }
        public byte[] GateExists { get; set; }
        public long? GuardTowerSettingId { get; set; }
        public byte[] HeavyTax { get; set; }
        public long? HousingDecoLimitId { get; set; }
        public long? HousingRebuildingPackId { get; set; }
        public long? HousingSizeId { get; set; }
        public long? HousingUccPackId { get; set; }
        public long? Hp { get; set; }
        public byte[] IsSellable { get; set; }
        public long? MainModelId { get; set; }
        public string Name { get; set; }
        public long? PackageDemolishSealCount { get; set; }
        public long? RepairCost { get; set; }
        public long? RotateItemCount { get; set; }
        public long? RotateItemId { get; set; }
        public long? ServerTransferDemolishRefundItemId { get; set; }
        public long? StairModelId { get; set; }
        public long? TaxationId { get; set; }

        public virtual Cinemas Cinema { get; set; }
        public virtual GuardTowerSettings GuardTowerSetting { get; set; }
        public virtual HousingDecoLimits HousingDecoLimit { get; set; }
        public virtual HousingRebuildingPacks HousingRebuildingPack { get; set; }
        public virtual HousingSizes HousingSize { get; set; }
        public virtual Taxations Taxation { get; set; }
        public virtual ICollection<HousingBindingDoodads> HousingBindingDoodads { get; set; }
        public virtual ICollection<HousingBuildSteps> HousingBuildSteps { get; set; }
        public virtual ICollection<HousingPackMembers> HousingPackMembers { get; set; }
        public virtual ICollection<HousingRebuildings> HousingRebuildings { get; set; }
    }
}
