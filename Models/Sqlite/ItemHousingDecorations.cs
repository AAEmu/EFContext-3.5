namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemHousingDecorations
    {
        public long? ItemId { get; set; }
        public long? DesignId { get; set; }
        public byte[] Restore { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
