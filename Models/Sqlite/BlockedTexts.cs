namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BlockedTexts
    {
        public long Id { get; set; }
        public long? Bytes { get; set; }
        public byte[] CheckChat { get; set; }
        public byte[] CheckName { get; set; }
        public byte[] PartialMatch { get; set; }
        public string Utf8str { get; set; }
    }
}
