namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TaggedItems
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? TagId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
