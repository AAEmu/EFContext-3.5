namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CustomizingItemAssets
    {
        public long? ItemId { get; set; }
        public long? CategoryId { get; set; }
        public long? DisplayOrder { get; set; }
        public byte[] IsNew { get; set; }
        public long? ModelId { get; set; }
        public byte[] TwoTone { get; set; }
        public byte[] UsePallet { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Models Model { get; set; }
    }
}
