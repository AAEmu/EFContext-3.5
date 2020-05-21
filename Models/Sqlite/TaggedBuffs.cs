namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TaggedBuffs
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? TagId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
