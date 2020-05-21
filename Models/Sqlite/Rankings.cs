using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Rankings
    {
        public Rankings()
        {
            ItemRankAssignments = new HashSet<ItemRankAssignments>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Option { get; set; }
        public string Schedule { get; set; }
        public string SeasonOff { get; set; }
        public string Tab { get; set; }
        public string Tooltip { get; set; }
        public long? TopRank { get; set; }

        public virtual ICollection<ItemRankAssignments> ItemRankAssignments { get; set; }
    }
}
