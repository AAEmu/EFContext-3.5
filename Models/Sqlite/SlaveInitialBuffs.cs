namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveInitialBuffs
    {
        public long? SlaveId { get; set; }
        public long? BuffId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Slaves Slave { get; set; }
    }
}
