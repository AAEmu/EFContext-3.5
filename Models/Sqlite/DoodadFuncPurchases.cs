namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncPurchases
    {
        public long Id { get; set; }
        public long? CoinCount { get; set; }
        public long? CoinItemId { get; set; }
        public long? Count { get; set; }
        public long? CurrencyId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
