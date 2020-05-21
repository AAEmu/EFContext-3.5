namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSockets
    {
        public long? ItemId { get; set; }
        public long? EisetId { get; set; }
        public long? EquipItemTagId { get; set; }
        public long? EquipItemId { get; set; }
        public long? EquipSlotGroupId { get; set; }
        public byte[] Extractable { get; set; }
        public byte[] IgnoreEquipItemTag { get; set; }
        public long? ItemSocketChanceId { get; set; }

        public virtual EquipSlotGroups EquipSlotGroup { get; set; }
        public virtual ItemTemplate Item { get; set; }
        public virtual ItemSocketChances ItemSocketChance { get; set; }
    }
}
