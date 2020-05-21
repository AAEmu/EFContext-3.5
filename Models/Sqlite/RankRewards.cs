using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RankRewards
    {
        public RankRewards()
        {
            RankRewardLinks = new HashSet<RankRewardLinks>();
        }

        public long Id { get; set; }
        public long? AppellationId { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemId { get; set; }
        public string Name { get; set; }
        public long? Weeks { get; set; }

        public virtual Appellations Appellation { get; set; }
        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
        public virtual ICollection<RankRewardLinks> RankRewardLinks { get; set; }
    }
}
