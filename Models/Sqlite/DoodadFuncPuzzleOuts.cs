namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncPuzzleOuts
    {
        public long Id { get; set; }
        public string Anim { get; set; }
        public long? Delay { get; set; }
        public long? GroupId { get; set; }
        public long? LootPackId { get; set; }
        public long? NextPhase { get; set; }
        public long? ProjectileDelay { get; set; }
        public long? ProjectileId { get; set; }
        public double? Ratio { get; set; }
        public long? SoundId { get; set; }

        public virtual Projectiles Projectile { get; set; }
        public virtual Sounds Sound { get; set; }
    }
}
