namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncBuffs
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? Count { get; set; }
        public long? PermId { get; set; }
        public double? Radius { get; set; }
        public long? RelationshipId { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
