namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncExchangeItems
    {
        public long Id { get; set; }
        public long? DoodadFuncExchangeId { get; set; }
        public long? ItemId { get; set; }
        public long? LootPackId { get; set; }

        public virtual DoodadFuncExchanges DoodadFuncExchange { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
