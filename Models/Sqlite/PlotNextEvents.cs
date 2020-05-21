namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PlotNextEvents
    {
        public long Id { get; set; }
        public byte[] AddAnimCsTime { get; set; }
        public byte[] CancelOnBigHit { get; set; }
        public byte[] Casting { get; set; }
        public byte[] CastingCancelable { get; set; }
        public byte[] CastingDelayable { get; set; }
        public long? CastingInc { get; set; }
        public byte[] CastingUseable { get; set; }
        public byte[] Channeling { get; set; }
        public long? Delay { get; set; }
        public long? EventId { get; set; }
        public byte[] Fail { get; set; }
        public byte[] HighAbilityResource { get; set; }
        public long? NextEventId { get; set; }
        public byte[] PerTarget { get; set; }
        public long? Position { get; set; }
        public long? Speed { get; set; }
        public byte[] UseExeTime { get; set; }
        public long? Weight { get; set; }
    }
}
