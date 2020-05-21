namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ExpeditionLevelBuffs
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? ExpeditionLevelId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual ExpeditionLevels ExpeditionLevel { get; set; }
    }
}
