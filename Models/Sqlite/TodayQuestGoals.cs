using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TodayQuestGoals
    {
        public TodayQuestGoals()
        {
            TodayQuestGoalItems = new HashSet<TodayQuestGoalItems>();
        }

        public long Id { get; set; }
        public string Comment { get; set; }
        public long? Level { get; set; }

        public virtual ICollection<TodayQuestGoalItems> TodayQuestGoalItems { get; set; }
    }
}
