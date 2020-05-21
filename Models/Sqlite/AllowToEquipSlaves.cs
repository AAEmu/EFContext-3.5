namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AllowToEquipSlaves
    {
        public long? SlaveEquipPackId { get; set; }
        public long? SlaveId { get; set; }

        public virtual Slaves Slave { get; set; }
        public virtual SlaveEquipPacks SlaveEquipPack { get; set; }
    }
}
