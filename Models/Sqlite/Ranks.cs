using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Ranks
    {
        public Ranks()
        {
            RankRewardLinks = new HashSet<RankRewardLinks>();
            RankScopeLinks = new HashSet<RankScopeLinks>();
        }

        public long Id { get; set; }
        public long? DayOfWeekId { get; set; }
        public long? EdDay { get; set; }
        public long? EdHour { get; set; }
        public long? EdMin { get; set; }
        public long? EdMonth { get; set; }
        public long? EdYear { get; set; }
        public long? EndTime { get; set; }
        public long? EndTimeAlarm { get; set; }
        public string EndTimeAlarmMsg { get; set; }
        public byte[] GlobalRanking { get; set; }
        public string Name { get; set; }
        public string ProcessExplain { get; set; }
        public long? RankKindId { get; set; }
        public byte[] RankerQueriable { get; set; }
        public long? ResetWeek { get; set; }
        public long? StDay { get; set; }
        public long? StHour { get; set; }
        public long? StMin { get; set; }
        public long? StMonth { get; set; }
        public long? StYear { get; set; }
        public long? StartTime { get; set; }
        public long? StartTimeAlarm { get; set; }
        public string StartTimeAlarmMsg { get; set; }
        public byte[] TabDisplay { get; set; }
        public string V1 { get; set; }
        public string V2 { get; set; }
        public string ValueColumnTooltip { get; set; }
        public long? ZoneGroupId { get; set; }

        public virtual ZoneGroups ZoneGroup { get; set; }
        public virtual ICollection<RankRewardLinks> RankRewardLinks { get; set; }
        public virtual ICollection<RankScopeLinks> RankScopeLinks { get; set; }
    }
}
