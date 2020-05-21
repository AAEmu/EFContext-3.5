namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AggroEffects
    {
        public long Id { get; set; }
        public long? ChargedBuffId { get; set; }
        public double? ChargedMul { get; set; }
        public long? FixedMax { get; set; }
        public long? FixedMin { get; set; }
        public double? LevelMd { get; set; }
        public long? LevelVaEnd { get; set; }
        public long? LevelVaStart { get; set; }
        public byte[] UseChargedBuff { get; set; }
        public byte[] UseFixedAggro { get; set; }
        public byte[] UseLevelAggro { get; set; }
    }
}
