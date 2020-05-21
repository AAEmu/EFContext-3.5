namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSecureExceptions
    {
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
