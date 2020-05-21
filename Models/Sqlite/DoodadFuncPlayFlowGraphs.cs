namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncPlayFlowGraphs
    {
        public long Id { get; set; }
        public long? EventOnPhaseChangeId { get; set; }
        public long? EventOnVisibleId { get; set; }
    }
}
