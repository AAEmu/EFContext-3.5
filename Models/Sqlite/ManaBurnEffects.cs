namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ManaBurnEffects
    {
        public long Id { get; set; }
        public long? BaseMax { get; set; }
        public long? BaseMin { get; set; }
        public long? DamageRatio { get; set; }
        public double? LevelMd { get; set; }
        public long? LevelVaEnd { get; set; }
        public long? LevelVaStart { get; set; }
    }
}
