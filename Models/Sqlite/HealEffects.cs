namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HealEffects
    {
        public long Id { get; set; }
        public double? ActabilityAdd { get; set; }
        public long? ActabilityGroupId { get; set; }
        public double? ActabilityMul { get; set; }
        public long? ActabilityStep { get; set; }
        public long? ChargedBuffId { get; set; }
        public double? ChargedMul { get; set; }
        public double? DpsMultiplier { get; set; }
        public string ExtraEffects { get; set; }
        public long? FixedMax { get; set; }
        public long? FixedMin { get; set; }
        public byte[] IgnoreHealAggro { get; set; }
        public double? LevelMd { get; set; }
        public long? LevelVaEnd { get; set; }
        public long? LevelVaStart { get; set; }
        public byte[] Percent { get; set; }
        public byte[] SlaveApplicable { get; set; }
        public byte[] UseChargedBuff { get; set; }
        public byte[] UseFixedHeal { get; set; }
        public byte[] UseLevelHeal { get; set; }

        public virtual ActabilityGroups ActabilityGroup { get; set; }
    }
}
