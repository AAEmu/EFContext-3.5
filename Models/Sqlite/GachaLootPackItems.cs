namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GachaLootPackItems
    {
        public long? GachaLootPackId { get; set; }
        public long? Kind { get; set; }
        public long? ItemId { get; set; }

        public virtual GachaLootPacks GachaLootPack { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
