namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSocketLevelLimits
    {
        public long? ItemId { get; set; }
        public long? Level { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
