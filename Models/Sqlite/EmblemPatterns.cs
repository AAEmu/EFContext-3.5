namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EmblemPatterns
    {
        public long Id { get; set; }
        public string IconPath { get; set; }
        public long? KindId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
