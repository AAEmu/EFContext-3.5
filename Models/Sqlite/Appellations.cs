using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Appellations
    {
        public Appellations()
        {
            QuestActSupplyAppellations = new HashSet<QuestActSupplyAppellations>();
            RankRewards = new HashSet<RankRewards>();
        }

        public long Id { get; set; }
        public byte[] ApplyAppellationAtOnce { get; set; }
        public long? BuffId { get; set; }
        public string Name { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual ICollection<QuestActSupplyAppellations> QuestActSupplyAppellations { get; set; }
        public virtual ICollection<RankRewards> RankRewards { get; set; }
    }
}
