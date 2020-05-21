namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemTools
    {
        public long? ItemId { get; set; }
        public long? AssetId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
