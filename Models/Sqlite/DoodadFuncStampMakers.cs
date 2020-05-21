namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncStampMakers
    {
        public long Id { get; set; }
        public byte[] ConsumeAll { get; set; }
        public long? ConsumeCount { get; set; }
        public long? ConsumeItemSetId { get; set; }
        public long? ConsumeItemId { get; set; }
        public long? ConsumeMoney { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
