namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncGrowths
    {
        public long Id { get; set; }
        public long? Delay { get; set; }
        public long? EndScale { get; set; }
        public long? NextPhase { get; set; }
        public long? StartScale { get; set; }
    }
}
