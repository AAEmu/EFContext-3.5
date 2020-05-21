namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemHousings
    {
        public long? ItemId { get; set; }
        public long? DesignId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
