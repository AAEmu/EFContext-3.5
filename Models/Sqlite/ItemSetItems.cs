namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSetItems
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? ItemSetId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemSets ItemSet { get; set; }
    }
}
