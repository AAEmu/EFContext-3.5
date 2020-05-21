namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSlaveEquipments
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public double? DoodadScale { get; set; }
        public long? DoodadId { get; set; }
        public long? RequireItemId { get; set; }
        public long? SlaveEquipPackId { get; set; }
        public long? SlaveId { get; set; }
        public long? SlotPackId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Slaves Slave { get; set; }
        public virtual SlaveEquipPacks SlaveEquipPack { get; set; }
    }
}
