namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UiTexts
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public string Key { get; set; }
        public string Text { get; set; }
    }
}
