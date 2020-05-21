namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TaggedImmuneBuffs
    {
        public long? BuffId { get; set; }
        public long? BuffTagId { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
