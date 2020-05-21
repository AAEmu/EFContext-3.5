namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BookPageContents
    {
        public long Id { get; set; }
        public long? BookPageId { get; set; }
        public string Illust { get; set; }
        public string Text { get; set; }

        public virtual BookPages BookPage { get; set; }
    }
}
