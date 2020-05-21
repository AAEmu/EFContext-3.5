namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncHungers
    {
        public long Id { get; set; }
        public long? FullStep { get; set; }
        public long? HungryTerm { get; set; }
        public long? NextPhase { get; set; }
        public long? PhaseChangeLimit { get; set; }
    }
}
