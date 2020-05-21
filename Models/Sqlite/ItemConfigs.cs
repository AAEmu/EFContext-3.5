namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConfigs
    {
        public double? DurabilityDecrementChance { get; set; }
        public double? DurabilityRepairCostFactor { get; set; }
        public double? DurabilityConst { get; set; }
        public double? HoldableDurabilityConst { get; set; }
        public double? WearableDurabilityConst { get; set; }
        public long? DeathDurabilityLossRatio { get; set; }
        public long? ItemStatConst { get; set; }
        public long? HoldableStatConst { get; set; }
        public long? WearableStatConst { get; set; }
        public long? StatValueConst { get; set; }
    }
}
