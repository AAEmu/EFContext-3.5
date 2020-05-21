namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncChangeOtherDoodadPhases
    {
        public long Id { get; set; }
        public long? NextPhase { get; set; }
        public long? TargetDoodadId { get; set; }
        public long? TargetPhase { get; set; }
    }
}
