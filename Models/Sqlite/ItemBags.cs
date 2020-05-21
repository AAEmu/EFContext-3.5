namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemBags
    {
        public long? ItemId { get; set; }
        public long? Capacity { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
