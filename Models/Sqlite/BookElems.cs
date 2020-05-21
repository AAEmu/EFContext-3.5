namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BookElems
    {
        public long Id { get; set; }
        public long? BookPageId { get; set; }
        public long? BookId { get; set; }

        public virtual Books Book { get; set; }
        public virtual BookPages BookPage { get; set; }
    }
}
