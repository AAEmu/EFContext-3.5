namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BagExpands
    {
        public long Id { get; set; }
        public long? CurrencyId { get; set; }
        public byte[] IsBank { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemId { get; set; }
        public long? Price { get; set; }
        public long? Step { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
