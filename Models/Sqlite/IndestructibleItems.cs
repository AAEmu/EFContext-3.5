namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class IndestructibleItems
    {
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
