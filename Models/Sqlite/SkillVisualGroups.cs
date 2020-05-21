namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkillVisualGroups
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? FxGroupId { get; set; }
        public long? Level { get; set; }
        public long? ProjectileId { get; set; }

        public virtual FxGroups FxGroup { get; set; }
        public virtual Projectiles Projectile { get; set; }
    }
}
