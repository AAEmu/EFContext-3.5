namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemLookRevertRequiredItems
    {
        public long Id { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemLookConvertId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemLookConverts ItemLookConvert { get; set; }
    }
}
