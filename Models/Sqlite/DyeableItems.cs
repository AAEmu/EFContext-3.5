namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DyeableItems
    {
        public long? ItemId { get; set; }
        public long? DefaultDyeingItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
