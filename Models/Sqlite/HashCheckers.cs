namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HashCheckers
    {
        public long Id { get; set; }
        public string Hash1 { get; set; }
        public string Hash2 { get; set; }
        public string Path { get; set; }
    }
}
