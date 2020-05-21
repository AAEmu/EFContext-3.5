namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PlotEventConditions
    {
        public long Id { get; set; }
        public long? ConditionId { get; set; }
        public long? EventId { get; set; }
        public byte[] NotifyFailure { get; set; }
        public long? Position { get; set; }
        public long? SourceId { get; set; }
        public long? TargetId { get; set; }
    }
}
