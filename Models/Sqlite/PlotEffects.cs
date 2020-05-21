namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PlotEffects
    {
        public long Id { get; set; }
        public string ActualType { get; set; }
        public long? ActualId { get; set; }
        public long? EventId { get; set; }
        public long? Position { get; set; }
        public long? SourceId { get; set; }
        public long? TargetId { get; set; }
    }
}
