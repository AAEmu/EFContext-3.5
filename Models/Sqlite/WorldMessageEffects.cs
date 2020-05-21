namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class WorldMessageEffects
    {
        public long Id { get; set; }
        public long? FactionScopeId { get; set; }
        public string IconKey { get; set; }
        public byte[] KillHero { get; set; }
        public long? KillStreakCount { get; set; }
        public string Message { get; set; }
        public byte[] ZoneGroupOnly { get; set; }
        public byte[] ZoneGroupWarState { get; set; }
    }
}
