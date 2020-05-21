namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemOpenPapers
    {
        public long? ItemId { get; set; }
        public long? BookPageId { get; set; }
        public long? BookId { get; set; }

        public virtual Books Book { get; set; }
        public virtual BookPages BookPage { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
