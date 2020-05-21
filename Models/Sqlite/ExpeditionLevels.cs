using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ExpeditionLevels
    {
        public ExpeditionLevels()
        {
            ExpeditionLevelBuffs = new HashSet<ExpeditionLevelBuffs>();
            ExpeditionLevelReqs = new HashSet<ExpeditionLevelReqs>();
        }

        public long Id { get; set; }
        public long? DailyExp { get; set; }
        public long? MemberLimit { get; set; }
        public long? NeedMoney { get; set; }
        public long? SimilarBuffTagId { get; set; }
        public long? SummonLimit { get; set; }
        public long? TotalExp { get; set; }

        public virtual ICollection<ExpeditionLevelBuffs> ExpeditionLevelBuffs { get; set; }
        public virtual ICollection<ExpeditionLevelReqs> ExpeditionLevelReqs { get; set; }
    }
}
