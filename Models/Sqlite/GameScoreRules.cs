namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GameScoreRules
    {
        public long Id { get; set; }
        public long? EventId { get; set; }
        public long? EventScore { get; set; }
        public long? EventTagId { get; set; }
        public long? EventValue { get; set; }
        public long? RuleSetCorps { get; set; }
        public long? RuleSetId { get; set; }
    }
}
