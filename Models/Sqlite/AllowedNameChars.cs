namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AllowedNameChars
    {
        public long Id { get; set; }
        public string Char { get; set; }
        public long? Bytes { get; set; }
    }
}
