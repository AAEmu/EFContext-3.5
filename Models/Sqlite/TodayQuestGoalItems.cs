namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TodayQuestGoalItems
    {
        public long Id { get; set; }
        public long? Goal { get; set; }
        public long? ItemNum { get; set; }
        public long? ItemId { get; set; }
        public long? TodayQuestGoalId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual TodayQuestGoals TodayQuestGoal { get; set; }
    }
}
