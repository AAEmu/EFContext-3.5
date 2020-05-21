namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EquipSlotGroupMaps
    {
        public long Id { get; set; }
        public long? EquipSlotGroupId { get; set; }
        public long? EquipSlotTypeId { get; set; }

        public virtual EquipSlotGroups EquipSlotGroup { get; set; }
    }
}
