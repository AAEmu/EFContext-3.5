namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveCustomizingEquipSlots
    {
        public long Id { get; set; }
        public long? EquipSlotId { get; set; }
        public string EquipSlotName { get; set; }
        public long? SlaveCustomizingId { get; set; }

        public virtual SlaveCustomizings SlaveCustomizing { get; set; }
    }
}
