namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffModifiers
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? BuffAttributeId { get; set; }
        public long? BuffId { get; set; }
        public byte[] Synergy { get; set; }
        public long? TagId { get; set; }
        public long? UnitModifierTypeId { get; set; }
        public long? Value { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
