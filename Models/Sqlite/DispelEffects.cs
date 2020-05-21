namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DispelEffects
    {
        public long Id { get; set; }
        public long? BuffTagId { get; set; }
        public long? CureCount { get; set; }
        public long? DispelCount { get; set; }
        public long? Stack { get; set; }
    }
}
