namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemEnchantingGems
    {
        public long? ItemId { get; set; }
        public long? EisetId { get; set; }
        public long? EquipItemTagId { get; set; }
        public long? EquipItemId { get; set; }
        public long? EquipLevel { get; set; }
        public long? EquipSlotGroupId { get; set; }
        public long? GemVisualEffectId { get; set; }
        public byte[] IgnoreEquipItemTag { get; set; }
        public long? ItemGradeId { get; set; }

        public virtual EquipSlotGroups EquipSlotGroup { get; set; }
        public virtual GemVisualEffects GemVisualEffect { get; set; }
        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
