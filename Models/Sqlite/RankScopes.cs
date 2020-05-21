using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RankScopes
    {
        public RankScopes()
        {
            RankRewardLinks = new HashSet<RankRewardLinks>();
            RankScopeLinks = new HashSet<RankScopeLinks>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? ScopeFrom { get; set; }
        public long? ScopeTo { get; set; }

        public virtual ICollection<RankRewardLinks> RankRewardLinks { get; set; }
        public virtual ICollection<RankScopeLinks> RankScopeLinks { get; set; }
    }
}
