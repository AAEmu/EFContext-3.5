namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveEquipSlots
    {
        public long Id { get; set; }
        public long? AttachPointId { get; set; }
        public long? EquipSlotId { get; set; }
        public long? RequireSlotId { get; set; }
        public long? SlaveId { get; set; }

        public virtual Slaves Slave { get; set; }
    }
}
