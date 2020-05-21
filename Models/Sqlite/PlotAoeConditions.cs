namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PlotAoeConditions
    {
        public long Id { get; set; }
        public long? ConditionId { get; set; }
        public long? EventId { get; set; }
        public long? Position { get; set; }
    }
}
