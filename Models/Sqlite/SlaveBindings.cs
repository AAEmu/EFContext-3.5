namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveBindings
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? AttachPointId { get; set; }
        public byte[] Basic { get; set; }
        public long? SlaveId { get; set; }

        public virtual Slaves Slave { get; set; }
    }
}
