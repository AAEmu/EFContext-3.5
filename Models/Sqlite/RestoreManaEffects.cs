namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RestoreManaEffects
    {
        public long Id { get; set; }
        public long? FixedMax { get; set; }
        public long? FixedMin { get; set; }
        public double? LevelMd { get; set; }
        public long? LevelVaEnd { get; set; }
        public long? LevelVaStart { get; set; }
        public byte[] Percent { get; set; }
        public byte[] UseFixedValue { get; set; }
        public byte[] UseLevelValue { get; set; }
    }
}
