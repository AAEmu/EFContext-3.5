namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TodayQuestGroupQuests
    {
        public long? TodayQuestGroupId { get; set; }
        public long? QuestContextId { get; set; }

        public virtual QuestContexts QuestContext { get; set; }
        public virtual TodayQuestGroups TodayQuestGroup { get; set; }
    }
}
