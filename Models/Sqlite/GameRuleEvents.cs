namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GameRuleEvents
    {
        public long Id { get; set; }
        public long? ConditionId { get; set; }
        public long? KindId { get; set; }
        public long? Param1 { get; set; }
        public long? Param2 { get; set; }
        public long? RuleSetId { get; set; }
    }
}
