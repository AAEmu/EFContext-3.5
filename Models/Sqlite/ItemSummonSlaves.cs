namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSummonSlaves
    {
        public long? ItemId { get; set; }
        public long? SlaveId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Slaves Slave { get; set; }
    }
}
