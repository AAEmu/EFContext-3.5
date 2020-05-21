namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class IgnoreTexts
    {
        public long Id { get; set; }
        public long? Bytes { get; set; }
        public string Utf8str { get; set; }
    }
}
