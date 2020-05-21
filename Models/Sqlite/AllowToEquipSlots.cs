namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AllowToEquipSlots
    {
        public long Id { get; set; }
        public long? DualEquipSlotId { get; set; }
        public long? EquipSlotId { get; set; }
        public long? SlaveEquipmentEquipSlotPackId { get; set; }

        public virtual SlaveEquipmentEquipSlotPacks SlaveEquipmentEquipSlotPack { get; set; }
    }
}
