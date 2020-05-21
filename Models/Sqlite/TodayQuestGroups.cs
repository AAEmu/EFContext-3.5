using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TodayQuestGroups
    {
        public TodayQuestGroups()
        {
            TodayQuestGroupQuests = new HashSet<TodayQuestGroupQuests>();
        }

        public long Id { get; set; }
        public byte[] AutomaticRestart { get; set; }
        public string Description { get; set; }
        public long? ExpeditionLevelMax { get; set; }
        public long? ExpeditionLevelMin { get; set; }
        public string Name { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? StepId { get; set; }

        public virtual ICollection<TodayQuestGroupQuests> TodayQuestGroupQuests { get; set; }
    }
}
