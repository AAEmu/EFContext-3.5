namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffUnitModifiers
    {
        public long Id { get; set; }
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? BuffId { get; set; }
        public long? TagId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
